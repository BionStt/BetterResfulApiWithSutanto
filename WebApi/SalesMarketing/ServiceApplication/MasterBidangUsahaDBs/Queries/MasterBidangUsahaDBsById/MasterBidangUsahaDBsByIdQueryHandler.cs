using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Infrastructure.Context;
using WebApi.SalesMarketing.ServiceApplication.MasterBidangUsahaDBs.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.MasterBidangUsahaDBs.Queries.MasterBidangUsahaDBsById
{
    public class MasterBidangUsahaDBsByIdQueryHandler : IRequestHandler<MasterBidangUsahaDBsByIdQuery, MasterBidangUsahaDBsByIdResponse>
    {
        private readonly SalesMarketingContext _context;

        public MasterBidangUsahaDBsByIdQueryHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<MasterBidangUsahaDBsByIdResponse> Handle(MasterBidangUsahaDBsByIdQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.MasterBidangUsahaDB.Where(x => x.NoUrutId == request.NoUrutId).Select(x => new MasterBidangUsahaDBsByIdResponse
            {
                NoUrutId = x.NoUrutId,
                MasterBidangUsaha = x.NamaMasterBidangUsaha,
                MasterBidangUsahaId = x.MasterBidangUsahaGuid

            }).SingleOrDefaultAsync();
            return returnQuery;
        }
    }
}
