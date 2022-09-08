using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Infrastructure.Context;
using WebApi.SalesMarketing.ServiceApplication.DataSPK.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.DataSPK.Queries.DataSPKById
{

    public class DataSPKByIdQueryHandler : IRequestHandler<DataSPKByIdQuery, DataSPKByIdResponse>
    {
        private readonly SalesMarketingContext _context;

        public DataSPKByIdQueryHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<DataSPKByIdResponse> Handle(DataSPKByIdQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.DataSPK.Where(x => x.NoUrutId == request.DataSPKId).Select(x => new DataSPKByIdResponse
            {
                DataSPKId = x.DataSPKId

            }).SingleOrDefaultAsync();

            return returnQuery;
        }
    }
}
