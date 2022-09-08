using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.ServiceApplication.Agama.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.Agama.Queries.AgamaListById
{
    public class AgamaListByIdQuery : IRequest<AgamaListByIdResponse>
    {
        public int AgamaId { get; set; }
    }
}
