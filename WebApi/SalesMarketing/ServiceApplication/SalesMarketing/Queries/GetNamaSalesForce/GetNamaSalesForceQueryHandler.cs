using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Infrastructure.Context;
using WebApi.SalesMarketing.ServiceApplication.SalesMarketing.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.SalesMarketing.Queries.GetNamaSalesForce
{
    public class GetNamaSalesForceQueryHandler : IRequestHandler<GetNamaSalesForceQuery, IReadOnlyCollection<GetNamaSalesForceResponse>>
    {
        private readonly SalesMarketingContext _context;

        public GetNamaSalesForceQueryHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<GetNamaSalesForceResponse>> Handle(GetNamaSalesForceQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.DataSalesMarketing.Select(x => new GetNamaSalesForceResponse
            {
                NoUrutId = x.NoUrutId,
                NamasalesForce = x.NamaSales
            }).ToListAsync();


            return returnQuery;

        }
    }
}
