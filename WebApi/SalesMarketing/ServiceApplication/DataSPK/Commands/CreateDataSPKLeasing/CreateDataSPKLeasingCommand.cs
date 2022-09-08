﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.SalesMarketing.ServiceApplication.DataSPK.Commands.CreateDataSPKLeasing
{
    public class CreateDataSPKLeasingCommand : IRequest<Guid>
    {
        public decimal Angsuran { get; set; }
        public string Mediator { get; set; }

        public int NamaSales { get; set; }
        public string NamaCMO { get; set; }
        public int Tenor { get; set; }
        public int DataSPKId { get; set; }
        public DateTime TanggalSurvei { get; set; }

        public string UserName { get; set; }
        public Guid UserNameId { get; set; }



    }
}
