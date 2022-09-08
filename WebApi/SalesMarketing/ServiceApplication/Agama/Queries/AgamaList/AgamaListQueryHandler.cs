using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Infrastructure.Context;
using WebApi.SalesMarketing.ServiceApplication.Agama.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.Agama.Queries.AgamaList
{
    public class AgamaListQueryHandler : IRequestHandler<AgamaListQuery, IReadOnlyCollection<AgamaListResponse>>
    {
        private readonly SalesMarketingContext _context;

        public AgamaListQueryHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<AgamaListResponse>> Handle(AgamaListQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.Agama.Select(x => new AgamaListResponse
            {
                AgamaListResponseId = x.AgamaId,
                AgamaKeterangan = x.AgamaKeterangan,
                NoUrutId = x.NoUrutId
            }).AsNoTracking().ToListAsync();

            return returnQuery;
        }
    }
}
