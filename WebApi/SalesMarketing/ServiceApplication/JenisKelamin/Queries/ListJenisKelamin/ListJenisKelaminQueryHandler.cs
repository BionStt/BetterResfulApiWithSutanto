using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Infrastructure.Context;
using WebApi.SalesMarketing.ServiceApplication.JenisKelamin.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.JenisKelamin.Queries.ListJenisKelamin
{
    public class ListJenisKelaminQueryHandler : IRequestHandler<ListJenisKelaminQuery, IReadOnlyCollection<ListJenisKelaminResponse>>
    {
        private readonly SalesMarketingContext _context;

        public ListJenisKelaminQueryHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<ListJenisKelaminResponse>> Handle(ListJenisKelaminQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.JenisKelamin.Select(x => new ListJenisKelaminResponse
            {
                NoUrutId = x.NoUrutId,
                JenisKelaminKeterangan = x.JenisKelaminKeterangan
            }).AsNoTracking().ToListAsync();

            return returnQuery;

        }
    }
}
