using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Infrastructure.Context;
using WebApi.SalesMarketing.ServiceApplication.MasterBidangUsahaDBs.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.MasterBidangUsahaDBs.Queries.GetNamaBidangUsaha
{
    public class GetNamaBidangUsahaQueryHandler : IRequestHandler<GetNamaBidangUsahaQuery, IReadOnlyCollection<GetNamaBidangUsahaResponse>>
    {
        private readonly SalesMarketingContext _context;

        public GetNamaBidangUsahaQueryHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<GetNamaBidangUsahaResponse>> Handle(GetNamaBidangUsahaQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.MasterBidangUsahaDB.Select(x => new GetNamaBidangUsahaResponse
            {
                NoKodeMasterBidangUsaha = x.NoUrutId,
                NamaMasterBidangUsaha = x.NamaMasterBidangUsaha

            }).AsNoTracking().ToListAsync();

            return returnQuery;
        }
    }
}
