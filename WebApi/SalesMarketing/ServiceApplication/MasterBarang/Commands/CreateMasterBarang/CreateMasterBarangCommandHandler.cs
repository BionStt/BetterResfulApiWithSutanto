﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Infrastructure.Context;

namespace WebApi.SalesMarketing.ServiceApplication.MasterBarang.Commands.CreateMasterBarang
{
    public class CreateMasterBarangCommandHandler : IRequestHandler<CreateMasterBarangCommand>
    {
        private readonly SalesMarketingContext _context;

        public CreateMasterBarangCommandHandler(SalesMarketingContext context)
        {
            _context = context;
        }


        public async Task<Unit> Handle(CreateMasterBarangCommand request, CancellationToken cancellationToken)
        {
            var mstBarang = Domain.MasterBarang.Create(request.NamaBarang, request.NomorRangka, request.NomorMesin, request.Merek
                , request.KapasitasMesin, request.HargaOff, request.BBn, request.TahunPerakitan, request.TypeKendaraan, request.MasterBarangId);

            await _context.MasterBarang.AddAsync(mstBarang);
            await _context.SaveChangesAsync();

            return Unit.Value;

        }
    }
}
