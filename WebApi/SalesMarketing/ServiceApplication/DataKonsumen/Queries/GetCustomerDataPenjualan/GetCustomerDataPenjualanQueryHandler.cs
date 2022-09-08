using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Infrastructure.Context;
using WebApi.SalesMarketing.ServiceApplication.DataKonsumen.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.DataKonsumen.Queries.GetCustomerDataPenjualan
{
    public class GetCustomerDataPenjualanQueryHandler : IRequestHandler<GetCustomerDataPenjualanQuery, IReadOnlyCollection<GetCustomerDataPenjualanResponse>>
    {
        private readonly SalesMarketingContext _context;

        public GetCustomerDataPenjualanQueryHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<GetCustomerDataPenjualanResponse>> Handle(GetCustomerDataPenjualanQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await (from a in _context.DataKonsumen
                                     where a.Terinput == null
                                     select new GetCustomerDataPenjualanResponse
                                     {
                                         NoCustomer = a.NoUrutId,
                                         NamaKonsumen = string.Format("{0} - {1} - {2}", a.Nama.NamaDepan, a.NamaBPKB.NamaDepan, a.AlamatTinggal.NoHandphone)
                                     }
                                     ).AsNoTracking().ToListAsync();

            return returnQuery;
        }
    }
}
