using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditLogging.Domain
{
    public class AuditLogEntity
    {
        public long Id { get; set; }

        public string UniqueId { get; set; }
        public string Action { get; set; }
        public string Data { get; set; }
    
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public TimeSpan? ResponseTime { get; set; }
        public string RequestStatus { get; set; }
        public string ErrorMessage { get; set; }
        public int? Stage { get; set; }
    
        public string WebUsername { get; set; }

        public string IpAddressV4 { get; set; }

        public string MachineName { get; set; }



        //   public string Message { get; set; }

        //  public BlogEventId EventId { get; set; }
        //  public string ResponseData { get; set; }
        // public BlogEventType EventType { get; set; }
        //  public int? CodeStatus { get; set; }
        //  public DateTime EventTimeUtc { get; set; }
    }
}
