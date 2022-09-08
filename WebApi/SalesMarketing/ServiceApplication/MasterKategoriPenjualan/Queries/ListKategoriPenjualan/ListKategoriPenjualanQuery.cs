using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.ServiceApplication.MasterKategoriPenjualan.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.MasterKategoriPenjualan.Queries.ListKategoriPenjualan
{
    public class ListKategoriPenjualanQuery : IRequest<IReadOnlyCollection<ListKategoriPenjualanResponse>>
    {

    }
}
