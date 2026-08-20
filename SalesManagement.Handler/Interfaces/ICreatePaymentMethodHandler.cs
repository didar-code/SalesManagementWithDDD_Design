using SalesManagement.DTOs.Commands;
using SalesManagement.DTOs.Responses.PaymentMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.Handler.Interfaces
{
    public interface ICreatePaymentMethodHandler
    {
        Task<PaymentMethodResponseDto> Handle(CreatePaymentMethodCommand command);
    }
}
