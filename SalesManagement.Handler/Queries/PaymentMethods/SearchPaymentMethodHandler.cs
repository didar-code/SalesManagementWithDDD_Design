using SalesManagement.DTOs.Queries;
using SalesManagement.DTOs.Responses.PaymentMethods;
using SalesManagement.Repository.Data;
using SalesManagement.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.Handler.Queries.PaymentMethods
{
    public class SearchPaymentMethodHandler
    {
        private readonly IPaymentMethodRepository _repository;

        public SearchPaymentMethodHandler(IPaymentMethodRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<PaymentMethodResponseDto>> Handle(SearchPaymentMethodQuery query)
        {
            var paymentMethods = await _repository.SearchAsync(query.Name, query.IsActive);

            return paymentMethods.Select(x => new PaymentMethodResponseDto
            {
                PaymentMethodId = x.PaymentMethodId,
                PaymentMethodName = x.PaymentMethodName,
                Description = x.Description,
                IsActive = x.IsActive,
                CreateDate = x.CreateDate
            }).ToList();
        }
    }
}
