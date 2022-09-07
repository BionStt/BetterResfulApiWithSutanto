using AuditLogging.Domain;
using AuditLogging.Services.Contract;
using AuditLogging.Services.Repository.Contract;
using AuditLogging.Services.Specifications;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.FeatureManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditLogging.Services.Implementation
{
    /// <summary>
    /// class ini untuk mencatat logging baik error atau berhasil dalam eksekusi suatu perintah program
    /// </summary>
    public class Audit: IAudit
    {
        private readonly ILogger<Audit> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IFeatureManager _featureManager;
        private readonly IAuditLogRepository _auditLogRepo;

        public Audit(ILogger<Audit> logger, IHttpContextAccessor httpContextAccessor, IFeatureManager featureManager, IAuditLogRepository auditLogRepo)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            _featureManager = featureManager;
            _auditLogRepo = auditLogRepo;
        }


        /// <summary>
        /// <c>AddAuditLogging</c> method ini untuk menginsert data logging ke dalam database dengan parameter yang terlampirkan  
        /// </summary>
        /// <param name="logStartTime">parameter ini mencatat waktu pertama kali logging dicatatatkan biasanya diletakkan dipaling atas dari suatu method utk memberitahukan suatu action mulai di eksekusi</param>
        /// <param name="errorMessage">parameter ini untuk mencatat pesan error atau pesan berhasil jika ada</param>
        /// <param name="uniqueId">parameter ini untuk mencatat kode unik biasanya dlm bentuk GUID yang di konversikan ke string</param>
        /// <param name="action">parameter ini mencatat nama action dalam suatu controller yang sedang di eksekusi contoh NamaController - NamaMethod (dalam string) </param>
        /// <param name="data">parameter ini mencatat data yang dikirimkan oleh user dalam bentuk json. untuk mengetahui data request apa yang menyebabkan error atau string.empty </param>
        /// <param name="createdBy">parameter ini mencatat userid yang melakukan interaksi dengan service</param>
        /// <param name="createdTime">parameter ini mencatat waktu ketika log ini dieksekusi </param>
        /// <param name="requestStatus">parameter ini mencatat request status dari eksekusi suatu service . bisa berhasil atau gagal (dalam bentuk string)</param>
        /// <param name="stage">parameter ini mencatat stage atau posisi service logging ini diletakkan didalam suatu method dalam controller</param>
        /// <param name="userName">parameter ini mencatat username dari pihak yang melakukan request terhadap seuatu service </param>
        /// <param name="ipV4">parameter ini mencatat Ip dari user yang melakukan request terhadap service</param>
        /// 
        ///<example>
        ///
        ///<code>
        /// var (username, ipv4) = GetUsernameAndIp();
        ///var logStart = DateTime.Now;
        /// var logGuid = Guid.NewGuid().ToString();
        /// await AddAuditLogging(logStart, $"Audit log was cleared by '{username}' from '{ipv4}'", logGuid, "ClearAuditLog", string.Empty,0, DateTime.Now,"Berhasil",0, username, ipv4);
        /// </code>
        /// 
        /// </example>
        /// <returns></returns>
        public async Task AddAuditLogging(DateTime? logStartTime,string errorMessage,string uniqueId,string action,string data,int? createdBy , DateTime createdTime,string requestStatus,int? stage, string userName, string ipV4)
        {
            try
            {
                if (!await IsAuditLogEnabled()) return;

             //   var (username, ipv4) = GetUsernameAndIp();

                // Truncate data so that SQL won't blow up
                if (errorMessage.Length > 256) errorMessage = errorMessage[..256];

                var machineName = Environment.MachineName;
                if (machineName.Length > 32) machineName = machineName[..32];

                var entity = new AuditLogEntity
                {
                    UniqueId = uniqueId,
                    Action = action,
                    Data = data,
                    CreatedBy = createdBy,
                    CreatedTime = createdTime,
                    ResponseTime = createdTime - logStartTime,                   
                    RequestStatus = requestStatus,
                    ErrorMessage = errorMessage,
                    Stage = stage,
                    IpAddressV4 = ipV4,
                    MachineName = machineName,            
                    WebUsername = userName
                    //  CodeStatus = codeStatus,
                    //   ResponseData = responseData,
                };
                await _auditLogRepo.AddAsync(entity);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
            }
        }

        public async Task<(IReadOnlyList<AuditLogEntity> Entries, int Count)> GetAuditEntries(int skip, int take)
        {
            var spec = new AuditPagingSpec(take, skip);
            var entries = await _auditLogRepo.GetAsync(spec);

            var totalRows = _auditLogRepo.Count();
            var returnType = (entries.ToList(), totalRows);

            return returnType;
        }

        /// <summary>
        /// untuk menghapus audit log dalam database
        /// </summary>
        /// <returns></returns>
        public async Task ClearAuditLog()
        {
            if (!await IsAuditLogEnabled()) return;

            await _auditLogRepo.ExecuteSqlRawAsync("DELETE FROM AuditLog");

            // Make sure who ever doing this can't get away with it
            var (username, ipv4) = GetUsernameAndIp();

            var logStart = DateTime.Now;
            var logGuid = Guid.NewGuid().ToString();

            await AddAuditLogging(logStart, $"Audit log was cleared by '{username}' from '{ipv4}'",logGuid, "ClearAuditLog",string.Empty,0,DateTime.Now,"Berhasil",0,username,ipv4);
           
           
        }

        private (string Username, string Ipv4) GetUsernameAndIp()
        {
            var uname = string.Empty;
            var ip = "0.0.0.0";

            if (_httpContextAccessor?.HttpContext is not null)
            {
                uname = _httpContextAccessor.HttpContext.User.Identity?.Name ?? "N/A";
                ip = _httpContextAccessor.HttpContext.Connection.RemoteIpAddress?.ToString();
            }

            return (uname, ip);
        }

        private async Task<bool> IsAuditLogEnabled()
        {
            var flag = await _featureManager.IsEnabledAsync("EnableAudit");
            return flag;
        }
    }
}
