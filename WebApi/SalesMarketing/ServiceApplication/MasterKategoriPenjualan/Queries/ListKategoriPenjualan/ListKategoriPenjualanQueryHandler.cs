using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Infrastructure.Context;
using WebApi.SalesMarketing.ServiceApplication.MasterKategoriPenjualan.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.MasterKategoriPenjualan.Queries.ListKategoriPenjualan
{
    public class ListKategoriPenjualanQueryHandler : IRequestHandler<ListKategoriPenjualanQuery, IReadOnlyCollection<ListKategoriPenjualanResponse>>
    {
        private readonly SalesMarketingContext _context;

        public ListKategoriPenjualanQueryHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<ListKategoriPenjualanResponse>> Handle(ListKategoriPenjualanQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.MasterKategoriPenjualan.Select(x => new ListKategoriPenjualanResponse
            {
                NoUrutId = x.NoUrutId,
                KategoriPenjualan = x.NamaKategoryPenjualan

            }).AsNoTracking().ToListAsync();

            return returnQuery;
        }
    }
}
