using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.ServiceApplication.StokUnit.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.StokUnit.Queries.GetDataSOByID
{
    public class GetDataSOByIDQuery : IRequest<GetDataSOByIDResponse>
    {
        public string Id { get; set; }
    }
}
