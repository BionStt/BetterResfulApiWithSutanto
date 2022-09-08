using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Infrastructure.Context;
using WebApi.SalesMarketing.ServiceApplication.MasterBidangPekerjaanDBs.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.MasterBidangPekerjaanDBs.Queries.MasterBidangPekerjaanDBsById
{
    public class MasterBidangPekerjaanDBsByIdQueryHandler : IRequestHandler<MasterBidangPekerjaanDBsByIdQuery, MasterBidangPekerjaanDBsByIdResponse>
    {
        private readonly SalesMarketingContext _context;

        public MasterBidangPekerjaanDBsByIdQueryHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<MasterBidangPekerjaanDBsByIdResponse> Handle(MasterBidangPekerjaanDBsByIdQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.MasterBidangPekerjaanDB.Where(x => x.NoUrutId == request.NoUrutId).Select(x => new MasterBidangPekerjaanDBsByIdResponse
            {
                NoUrutId = x.NoUrutId,
                MasterBidangPekerjaan = x.NamaMasterBidangPekerjaan,
                MasterBidangPekerjaanId = x.MasterBidangPekerjaanDBGuid

            }).SingleOrDefaultAsync();

            return returnQuery;
        }
    }
}
