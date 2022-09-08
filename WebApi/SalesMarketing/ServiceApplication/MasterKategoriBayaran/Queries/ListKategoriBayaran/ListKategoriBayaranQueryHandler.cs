using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Infrastructure.Context;
using WebApi.SalesMarketing.ServiceApplication.MasterKategoriBayaran.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.MasterKategoriBayaran.Queries.ListKategoriBayaran
{
    public class ListKategoriBayaranQueryHandler : IRequestHandler<ListKategoriBayaranQuery, IReadOnlyCollection<ListKategoriBayaranResponse>>
    {
        private readonly SalesMarketingContext _context;

        public ListKategoriBayaranQueryHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<ListKategoriBayaranResponse>> Handle(ListKategoriBayaranQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.MasterKategoriBayaran.Select(x => new ListKategoriBayaranResponse
            {

                NoUrutId = x.NoUrutId,
                KategoriBayaran = x.NamaKategoryBayaran

            }).AsNoTracking().ToListAsync();

            return returnQuery;
        }
    }
}
