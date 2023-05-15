using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Security.Claims;
using WebApi.DTO.DataKonsumen;
using WebApi.DTOMapping;
using WebApi.SalesMarketing.ServiceApplication.Agama.DTO;
using WebApi.SalesMarketing.ServiceApplication.Agama.Queries.AgamaList;
using WebApi.SalesMarketing.ServiceApplication.JenisKelamin.DTO;
using WebApi.SalesMarketing.ServiceApplication.JenisKelamin.Queries.ListJenisKelamin;
using WebApi.SalesMarketing.ServiceApplication.MasterBidangPekerjaanDBs.DTO;
using WebApi.SalesMarketing.ServiceApplication.MasterBidangPekerjaanDBs.Queries.GetNamaBidangPekerjaan;
using WebApi.SalesMarketing.ServiceApplication.MasterBidangUsahaDBs.DTO;
using WebApi.SalesMarketing.ServiceApplication.MasterBidangUsahaDBs.Queries.GetNamaBidangUsaha;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataKonsumenController : ControllerBase
    {
        private readonly ILogger<DataKonsumenController> _logger;

        private IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string _userId;

        public DataKonsumenController(ILogger<DataKonsumenController> logger, IMediator mediator, IHttpContextAccessor httpContextAccessor, string userId)
        {
            _logger = logger;
            _mediator = mediator;
            _httpContextAccessor = httpContextAccessor;
            //_userId = userId;
            _userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;//userID Guid

        }

        //[SwaggerOperation(Summary = "Simpan data ke db xx ",Tags = new[] { "xxR333369 - External" },Description = "service ini menginput data kiriman dari eform ke db xxxx")]
        /// <summary>
        /// menampilkan list data bidang pekerjaan
        /// </summary>
        /// <returns>GetNamaBidangPekerjaanResponse</returns>
        [HttpGet("GetNamaBidangPekerjaanAsync")]
        public async Task<IReadOnlyCollection<GetNamaBidangPekerjaanResponse>> GetNamaBidangPekerjaanAsync()
        {
            var listNamaBidangPekerjaan = await _mediator.Send(new GetNamaBidangPekerjaanQuery());
            return listNamaBidangPekerjaan;
        }


        /// <summary>
        /// menampilkan list data Bidang usaha
        /// </summary>
        /// <returns>GetNamaBidangUsahaResponse</returns>
        [HttpGet("GetNamaBidangUsahaAsync")]
        public async Task<IReadOnlyCollection<GetNamaBidangUsahaResponse>> GetNamaBidangUsahaAsync()
        {
            var listNamaBidangUsaha = await _mediator.Send(new GetNamaBidangUsahaQuery());
            return listNamaBidangUsaha;
        }

        /// <summary>
        /// menampilkan list data jenis kelamin
        /// </summary>
        /// <returns>ListJenisKelaminResponse</returns>
        [HttpGet("GetJenisKelaminAsync")]
        public async Task<IReadOnlyCollection<ListJenisKelaminResponse>> GetJenisKelaminAsync()
        {
            var listJenisKelamin = await _mediator.Send(new ListJenisKelaminQuery());
            return listJenisKelamin;
        }

        /// <summary>
        /// menampilkan list data jenis kelamin
        /// </summary>
        /// <returns>ListJenisKelaminResponse</returns>
        /// <remarks>
        /// ### REMARKS ###
        /// The following codes are returned
        /// - 400 - No sub domain is found that matches the SubDomainName property
        /// - 200 - Updated an existing API object
        /// - 201 - Created a new API object
        /// </remarks>
         [HttpGet("GetAgamaListAsync")]
        public async Task<IReadOnlyCollection<AgamaListResponse>> GetAgamaListAsync()
        {
            var listAgama = await _mediator.Send(new AgamaListQuery());
            return listAgama;
        }


        /// <summary>
        /// CreateDataKonsumen action adalah untuk menginput data konsumen baru
        /// </summary>
        /// <param name="model">parameter inputan yang diperlukan</param>
        /// <returns>mengembalikan id dari hasil inputan</returns>
        /// <response code="201">return the newly created item</response>
        /// <response code="400">if the model is null</response>
        /// <remarks>
        /// sample request:
        ///      Post api/CreateDataKonsumenAsync
        ///      {
        ///           //Contoh pengisian parameter
        /// "sortColumn": "",
        ///"sortColumnDir": "",
        ///"pageNumber": 1,
        ///"pageSize": 10,
        ///"searchParam": "",
        ///"groupId": "",
        ///"groupIdName": "",
        ///"parentId": "",
        ///"parentIdName": "",
        ///"clientId": 0,
        ///"leadsId": 0,
        ///"memoId": ""
        /// 
        ///      }
        /// </remarks>
        [HttpPost("CreateDataKonsumenAsync")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        // [Produces("application/json")]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDataKonsumenAsync(CreateDataKonsumenRequest customerViewModel)
        {

            var dtKonsumen = customerViewModel.ToCommand();
            var aa = await _mediator.Send(dtKonsumen);//mediator pattern 

            return Created(nameof(this.CreateDataKonsumenAsync), aa);
        }

        [HttpPost("testerror1")]
        public async Task<IActionResult> testerror1(string test1)
        {

            return Problem(
                "Productiion has no qunatity on hand",
                $"/sales/products/asasa/availableforsale",
                404,
                "cannot set product as available for sale",
                "http://example.com/problems/no-quantity-on-hand"
                );
            //return Ok();
        }

        [HttpPost("testerror2")]
        public async Task<IActionResult> testerror2(string test1)
        {
            var returnProblem = new ProblemDetails()
            {
                Type = "https://example.com/probs/out-of-credit",
                Title = "yo dont have enought credits",
                Detail = "your current balanceis 30 , but that costs 50",
                Instance = "/account/12345/msgs/abc"

            };

            return BadRequest(returnProblem);
            //return Ok();
        }
        
        [HttpPost("testerror3")]
        public async Task<IActionResult> testerror3(string test1)
        {
            var returnProblem = new OutOfCreditsProblemDetails()
            {
                Type = "https://example.com/probs/out-of-credit",
                Title = "yo dont have enought credits",
                Detail = "your current balanceis 30 , but that costs 50",
                Instance = "/account/12345/msgs/abc",
                Balance = 30.0m,
                Accounts = {"/account/12345","/account/678676"}

            };

            return BadRequest(returnProblem);
            //return Ok();
        }
    }

    public class OutOfCreditsProblemDetails : ProblemDetails
    {
        public OutOfCreditsProblemDetails()
        {
            Accounts = new List<string>();
        }

        public decimal Balance { get; set; }
        public ICollection<string> Accounts { get; set; }

    }

    
}
