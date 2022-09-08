using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Infrastructure.Context;
using WebApi.SalesMarketing.ServiceApplication.MasterBarang.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.MasterBarang.Queries.GetNamaBarang
{
    public class GetNamaBarangQueryHandler : IRequestHandler<GetNamaBarangQuery, IReadOnlyCollection<GetNamaBarangResponse>>
    {
        private readonly SalesMarketingContext _context;

        public GetNamaBarangQueryHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<GetNamaBarangResponse>> Handle(GetNamaBarangQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.MasterBarang.Select(x => new GetNamaBarangResponse
            {
                NoUrutKendaraan = x.NoUrutId,
                NamaBarang = x.NamaBarang

            }).AsNoTracking().ToListAsync();

            return returnQuery;
        }
    }
}
