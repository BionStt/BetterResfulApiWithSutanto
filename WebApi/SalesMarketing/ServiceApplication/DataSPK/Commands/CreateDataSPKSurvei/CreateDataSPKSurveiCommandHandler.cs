using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Infrastructure.Context;

namespace WebApi.SalesMarketing.ServiceApplication.DataSPK.Commands.CreateDataSPKSurvei
{
    public class CreateDataSPKSurveiCommandHandler : IRequestHandler<CreateDataSPKSurveiCommand, Guid>
    {
        private readonly SalesMarketingContext _context;

        public CreateDataSPKSurveiCommandHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateDataSPKSurveiCommand request, CancellationToken cancellationToken)
        {
            //mau diisi user
            var dtSPKbary = Domain.DataSPK.CreateDataSPKBaru(request.LokasiSPK, request.UserName, request.userNameId);
            var dtSPKSurvei = Domain.DataSPKSurvei.CreateDataSPKSurvei(request.NoKTPPemesan, request.NamaPemesan, request.AlamatPemesan, request.DataNPWPPemesan, request.PekerjaanPemesan, dtSPKbary.DataSPKId);
           
            dtSPKbary.AddDataSPKSurvei(dtSPKSurvei);
            await _context.DataSPK.AddAsync(dtSPKbary);
          //  await _context.DataSPKSurvei.AddAsync(dtSPKSurvei);
            await _context.SaveChangesAsync();

            return dtSPKSurvei.DataSPKSurveiId;
        }
    }
}
