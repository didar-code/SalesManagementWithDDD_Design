using SalesManagement.DTOs.Queries;
using SalesManagement.DTOs.Responses.PaymentMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.Handler.Interfaces
{
    public interface ISearchPaymentMethodHandler
    {
        Task<List<PaymentMethodResponseDto>> Handle(SearchPaymentMethodQuery query);
    }
}
