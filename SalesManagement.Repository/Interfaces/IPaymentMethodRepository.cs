using SalesManagement.Aggregators.PaymentMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.Repository.Interfaces
{
    public interface IPaymentMethodRepository
    {
        Task AddAsync(PaymentMethod paymentMethod);

        Task<List<PaymentMethod>> SearchAsync(string? name,bool? isActive);

        Task SaveAsync();
    }
}
