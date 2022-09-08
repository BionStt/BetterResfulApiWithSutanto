using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.ServiceApplication.JenisKelamin.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.JenisKelamin.Queries.ListJenisKelaminById
{
    public class ListJenisKelaminByIdQuery : IRequest<ListJenisKelaminByIdResponse>
    {
        public int NoUrutId { get; set; }
    }
}
