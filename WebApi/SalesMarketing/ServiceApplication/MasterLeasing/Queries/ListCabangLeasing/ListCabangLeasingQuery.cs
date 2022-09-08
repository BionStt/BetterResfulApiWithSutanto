﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.ServiceApplication.MasterLeasing.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.MasterLeasing.Queries.ListCabangLeasing
{
    public class ListCabangLeasingQuery : IRequest<IReadOnlyCollection<ListCabangLeasingResponse>>
    {

    }
}