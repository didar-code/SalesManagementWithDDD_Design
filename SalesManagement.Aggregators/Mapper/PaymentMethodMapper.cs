using SalesManagement.Aggregators.PaymentMethods;
using SalesManagement.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.Aggregators.Mapper
{
    public static class PaymentMethodMapper
    {
        public static PaymentMethodResponseDto ToResponse( PaymentMethodAggregatorsRoot paymentMethod)
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
        public static List<PaymentMethodResponseDto> ToResponseList(List<PaymentMethodAggregatorsRoot> paymentMethods)
        {
            return paymentMethods.Select(ToResponse).ToList();
        }
    }
}
