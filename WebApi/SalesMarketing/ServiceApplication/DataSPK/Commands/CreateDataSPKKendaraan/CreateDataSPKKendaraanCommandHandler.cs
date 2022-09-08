using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Infrastructure.Context;
using WebApi.SalesMarketing.ServiceApplication.MasterBarang.Queries.MasterBarangById;

namespace WebApi.SalesMarketing.ServiceApplication.DataSPK.Commands.CreateDataSPKKendaraan
{
    public class CreateDataSPKKendaraanCommandHandler : IRequestHandler<CreateDataSPKKendaraanCommand, Guid>
    {
        private readonly SalesMarketingContext _context;
        private IMediator _mediator;
        public CreateDataSPKKendaraanCommandHandler(SalesMarketingContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task<Guid> Handle(CreateDataSPKKendaraanCommand request, CancellationToken cancellationToken)
        {
            var mstBarang = await _mediator.Send(new MasterBarangByIdQuery { MasterBarangId = request.MasterBarangId });
            var dtSPKId = await _context.DataSPK.Where(x => x.NoUrutId == request.DataSPKId).Select(x => x.DataSPKId).SingleOrDefaultAsync();
            //var dtSPKId2 = await _context.DataSPK.Where(x => x.NoUrutId == request.DataSPKId).SingleOrDefaultAsync();
            var dtSPKId2 = await _context.DataSPK.SingleOrDefaultAsync(x => x.NoUrutId == request.DataSPKId);

            var dtSpkKendaraan = Domain.DataSPKKendaraan.CreateDataSPKKendaraan(request.TahunPerakitan, request.Warna, request.NamaSTNK, request.NoKTPSTNK, mstBarang.MasterBarangIdGuid, dtSPKId, request.UserName, request.UserNameId);
            if (dtSPKId2 != null)
            {
                dtSPKId2.AddDataSPKKendaraan(dtSpkKendaraan);
            }

            //   await _context.DataSPKKendaraan.AddAsync(dtSpkKendaraan);
             // await _context.DataSPK.AddAsync(dtSPKId2);
            await _context.SaveChangesAsync();

            return dtSpkKendaraan.DataSPKKendaraanId;
        }
    }
}
