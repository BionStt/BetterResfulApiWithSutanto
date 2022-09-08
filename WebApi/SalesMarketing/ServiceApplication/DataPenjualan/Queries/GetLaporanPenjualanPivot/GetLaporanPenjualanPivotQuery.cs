using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.ServiceApplication.DataPenjualan.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.DataPenjualan.Queries.GetLaporanPenjualanPivot
{
    public class GetLaporanPenjualanPivotQuery : IRequest<IReadOnlyCollection<GetLaporanPenjualanPivotResponse>>
    {
        public DateTime PeriodeAwal { get; set; }
        public DateTime PeriodeAkhir { get; set; }

    }
}
