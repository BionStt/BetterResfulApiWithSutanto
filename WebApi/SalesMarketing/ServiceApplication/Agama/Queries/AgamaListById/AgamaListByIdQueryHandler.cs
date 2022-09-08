using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Infrastructure.Context;
using WebApi.SalesMarketing.ServiceApplication.Agama.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.Agama.Queries.AgamaListById
{
    public class AgamaListByIdQueryHandler : IRequestHandler<AgamaListByIdQuery, AgamaListByIdResponse>
    {
        private readonly SalesMarketingContext _context;

        public AgamaListByIdQueryHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<AgamaListByIdResponse> Handle(AgamaListByIdQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.Agama.Where(x => x.NoUrutId == request.AgamaId).Select(x => new AgamaListByIdResponse
            {
                AgamaListByIdResponseId = x.AgamaId,
                AgamaKeterangan = x.AgamaKeterangan,
                NoUrutId = x.NoUrutId

            }).AsNoTracking().SingleOrDefaultAsync();

            return returnQuery;
        }
    }
}
