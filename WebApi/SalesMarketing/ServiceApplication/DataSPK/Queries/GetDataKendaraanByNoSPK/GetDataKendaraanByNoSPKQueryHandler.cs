﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Infrastructure.Context;
using WebApi.SalesMarketing.ServiceApplication.DataSPK.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.DataSPK.Queries.GetDataKendaraanByNoSPK
{
    public class GetDataKendaraanByNoSPKQueryHandler : IRequestHandler<GetDataKendaraanByNoSPKQuery, GetDataKendaraanByNoSPKResponse>
    {
        private readonly SalesMarketingContext _context;

        public GetDataKendaraanByNoSPKQueryHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<GetDataKendaraanByNoSPKResponse> Handle(GetDataKendaraanByNoSPKQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await (from a in _context.DataSPK
                                     join c in _context.DataSPKKendaraan on a.DataSPKId equals c.DataSPKId
                                     join b in _context.MasterBarang on c.MasterBarangId equals b.MasterBarangId
                                     where a.NoUrutId == int.Parse(request.Id)
                                     select new GetDataKendaraanByNoSPKResponse
                                     {
                                         BBN = b.Bbn,
                                         HargaOff = b.HargaOff
                                     }

                ).SingleOrDefaultAsync();

            return returnQuery;
        }
    }
}
