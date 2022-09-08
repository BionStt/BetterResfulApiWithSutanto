using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Infrastructure.Context;
using WebApi.SalesMarketing.ServiceApplication.MasterBarang.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.MasterBarang.Queries.MasterBarangById
{
    public class MasterBarangByIdQueryHandler : IRequestHandler<MasterBarangByIdQuery, MasterBarangByIdResponse>
    {
        private readonly SalesMarketingContext _context;

        public MasterBarangByIdQueryHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<MasterBarangByIdResponse> Handle(MasterBarangByIdQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.MasterBarang.Where(x => x.NoUrutId == request.MasterBarangId).Select(x => new MasterBarangByIdResponse
            {
                NoUrutId = x.NoUrutId,
                MasterBarangIdGuid = x.MasterBarangId,
                NamaBarang = x.NamaBarang
            }).SingleOrDefaultAsync();
            return returnQuery;
        }
    }
}
