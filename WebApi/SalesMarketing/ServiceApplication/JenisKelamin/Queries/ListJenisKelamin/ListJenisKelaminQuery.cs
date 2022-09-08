using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.ServiceApplication.JenisKelamin.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.JenisKelamin.Queries.ListJenisKelamin
{
    public class ListJenisKelaminQuery : IRequest<IReadOnlyCollection<ListJenisKelaminResponse>>
    {

    }
}
