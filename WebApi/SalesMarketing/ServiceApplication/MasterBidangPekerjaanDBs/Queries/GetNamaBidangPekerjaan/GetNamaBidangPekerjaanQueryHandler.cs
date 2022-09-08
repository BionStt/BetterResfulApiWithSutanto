using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Infrastructure.Context;
using WebApi.SalesMarketing.ServiceApplication.MasterBidangPekerjaanDBs.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.MasterBidangPekerjaanDBs.Queries.GetNamaBidangPekerjaan
{
    public class GetNamaBidangPekerjaanQueryHandler : IRequestHandler<GetNamaBidangPekerjaanQuery, IReadOnlyCollection<GetNamaBidangPekerjaanResponse>>
    {
        private readonly SalesMarketingContext _dbcontext;

        public GetNamaBidangPekerjaanQueryHandler(SalesMarketingContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<IReadOnlyCollection<GetNamaBidangPekerjaanResponse>> Handle(GetNamaBidangPekerjaanQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _dbcontext.MasterBidangPekerjaanDB.Select(x => new GetNamaBidangPekerjaanResponse
            {
                NoUrutBidangPekerjaan = x.NoUrutId,
                NamaMasterBidangPekerjaan = x.NamaMasterBidangPekerjaan

            }).AsNoTracking().ToListAsync();

            return returnQuery;
        }
    }
}
