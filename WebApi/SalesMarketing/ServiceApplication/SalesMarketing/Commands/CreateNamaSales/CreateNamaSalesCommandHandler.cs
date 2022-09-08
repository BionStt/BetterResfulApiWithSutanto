using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Infrastructure.Context;

namespace WebApi.SalesMarketing.ServiceApplication.SalesMarketing.Commands.CreateNamaSales
{
    public class CreateNamaSalesCommandHandler : IRequestHandler<CreateNamaSalesCommand>
    {
        private readonly SalesMarketingContext _context;

        public CreateNamaSalesCommandHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateNamaSalesCommand request, CancellationToken cancellationToken)
        {
            var dtSales = new Domain.DataSalesMarketing();
            dtSales.NamaSales = request.NamaSales;
            dtSales.DataSalesMarketingId = request.DataSalesMarketingId;
            await _context.DataSalesMarketing.AddAsync(dtSales);
            await _context.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
