using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.ServiceApplication.DataPenjualan.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.DataPenjualan.Queries.GetDataPenjualanBulananBySales
{
    public class GetDataPenjualanBulananBySalesQuery : IRequest<IReadOnlyCollection<GetDataPenjualanBulananBySalesResponse>>
    {
        public DateTime PeriodeAwal { get; set; }
        public DateTime PeriodeAkhir { get; set; }
        public string NoUrutSales { get; set; }
    }
}
