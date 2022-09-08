using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.ServiceApplication.MasterKategoriCaraPembayaran.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.MasterKategoriCaraPembayaran.Queries.ListKategoriCaraPembayaran
{
    public class ListKategoriCaraPembayaranQuery : IRequest<IReadOnlyCollection<ListKategoriCaraPembayaranResponse>>
    {

    }
}
