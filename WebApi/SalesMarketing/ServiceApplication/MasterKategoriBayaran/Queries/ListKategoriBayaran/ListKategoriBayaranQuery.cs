using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.ServiceApplication.MasterKategoriBayaran.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.MasterKategoriBayaran.Queries.ListKategoriBayaran
{
    public class ListKategoriBayaranQuery : IRequest<IReadOnlyCollection<ListKategoriBayaranResponse>>
    {

    }
}
