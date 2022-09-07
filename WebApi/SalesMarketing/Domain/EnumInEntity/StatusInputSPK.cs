using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.SalesMarketing.Domain.EnumInEntity
{
    public class StatusInputSPK
    {
        private StatusInputSPK(string statusInputSPKKeterangan)
        {
            StatusInputSPKId = Guid.NewGuid();
            StatusInputSPKKeterangan = statusInputSPKKeterangan;
        }
        public static StatusInputSPK AddStatusInputSPK(string statusInputSPKKeterangan)
        {
            return new StatusInputSPK(statusInputSPKKeterangan);
        }
        public Guid StatusInputSPKId { get; set; }
        public int NoUrutId { get; set; }
        public String StatusInputSPKKeterangan { get; set; }
    }

    //public enum StatusInputSPK
    //{
    //    Disurvei = 0,
    //    DiAcc = 1,
    //    Ditolaks = 2,
    //    DiKirimUnit = 3
    //}

}
