using Microsoft.EntityFrameworkCore;
using SalesManagement.Aggregators.PaymentMethods;
using SalesManagement.Repository.Data;
using SalesManagement.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.Repository.Implementations
{
    public class PaymentMethodRepository : IPaymentMethodRepository
    {
        private readonly AppDbContext _context;

        public PaymentMethodRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(PaymentMethod paymentMethod)
        {
            await _context.PaymentMethods.AddAsync(paymentMethod);
        }

        public async Task<List<PaymentMethod>> SearchAsync(
            string? name,
            bool? isActive)
        {
            var query = _context.PaymentMethods.AsQueryable();

            if (!string.IsNullOrWhiteSpace(name))
            {
                query = query.Where(x =>
                    x.PaymentMethodName.Contains(name));
            }

            if (isActive.HasValue)
            {
                query = query.Where(x =>
                    x.IsActive == isActive.Value);
            }

            return await query.ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
