using SalesManagement.Aggregators.PaymentMethods;
using SalesManagement.DTOs.Responses.PaymentMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.Aggregators.Mapper
{
    public static class PaymentMethodMapper
    {
        public static PaymentMethodResponseDto ToResponse( PaymentMethod paymentMethod)
        {
            return new PaymentMethodResponseDto
            {
                PaymentMethodId = paymentMethod.PaymentMethodId,
                PaymentMethodName = paymentMethod.PaymentMethodName,
                Description = paymentMethod.Description,
                IsActive = paymentMethod.IsActive,
                CreateDate = paymentMethod.CreateDate
            };
        }
        public static List<PaymentMethodResponseDto> ToResponseList(List<PaymentMethod> paymentMethods)
        {
            return paymentMethods.Select(ToResponse).ToList();
        }
    }
}
