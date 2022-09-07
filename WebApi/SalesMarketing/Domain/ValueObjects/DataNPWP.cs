using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.SalesMarketing.Domain.ValueObjects
{
    public class DataNPWP
    {
        //utk ef core
        protected DataNPWP()
        {

        }
        public static DataNPWP Create(string noNPWP, string namaNPWP, Alamat alamatNPWP)
        {
            return new DataNPWP(noNPWP, namaNPWP, alamatNPWP);
        }
        private DataNPWP(string noNPWP, string namaNPWP, Alamat alamatNPWP)
        {
            NoNPWP = noNPWP;
            NamaNPWP = namaNPWP;
            AlamatNPWP = alamatNPWP;
        }

        public string NoNPWP { get; private set; }
        public string NamaNPWP { get; private set; }
        public Alamat AlamatNPWP { get; private set; }

    }
}
