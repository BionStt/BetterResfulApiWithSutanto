using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Infrastructure.Context;
using WebApi.SalesMarketing.ServiceApplication.JenisKelamin.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.JenisKelamin.Queries.ListJenisKelaminById
{
    public class ListJenisKelaminByIdQueryHandler : IRequestHandler<ListJenisKelaminByIdQuery, ListJenisKelaminByIdResponse>
    {
        private readonly SalesMarketingContext _context;

        public ListJenisKelaminByIdQueryHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<ListJenisKelaminByIdResponse> Handle(ListJenisKelaminByIdQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.JenisKelamin.Where(x => x.NoUrutId == request.NoUrutId).Select(x => new ListJenisKelaminByIdResponse
            {
                NoUrutId = x.NoUrutId,
                JenisKelaminKeterangan = x.JenisKelaminKeterangan,
                ListJenisKelaminResponseId = x.JenisKelaminId

            }).SingleOrDefaultAsync();

            return returnQuery;

        }
    }
}
