﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.SalesMarketing.ServiceApplication.PermohonanBPKB.Commands.CreatePermohonanBPKB
{
    public class CreatePermohonanBPKBCommand : IRequest<Guid>
    {

        public int? NoUrutFaktur { get; set; }

        public string NoBpkb { get; set; }

        public DateTime TanggalTerimaBPKB { get; set; }
        public string UserName { get; set; }
        public Guid UserNameId { get; set; }


    }
}
