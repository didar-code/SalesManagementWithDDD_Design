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
        Task AddAsync(PaymentMethodAggregatorsRoot paymentMethod);

        Task<List<PaymentMethodAggregatorsRoot>> SearchAsync(string? name,bool? isActive);

        Task SaveAsync();
    }
}
