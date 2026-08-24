using SalesManagement.Aggregators.Mapper;
using SalesManagement.DTOs.Queries;
using SalesManagement.DTOs.Responses;
using SalesManagement.Repository.Data;
using SalesManagement.Repository.Interfaces;
using SalesManagement.Shared.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.Handler.Queries
{
    public class SearchPaymentMethodHandler: IQueryHandler<SearchPaymentMethodQuery, IEnumerable<PaymentMethodResponseDto>>
    {
        private readonly IPaymentMethodRepository _repository;

        public SearchPaymentMethodHandler(IPaymentMethodRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<PaymentMethodResponseDto>> HandleAsync(SearchPaymentMethodQuery query)
        {
            var paymentMethods = await _repository.SearchAsync(query.Name, query.IsActive);

            //return PaymentMethodMapper.ToResponseList(paymentMethods);
            return paymentMethods.Select(pm => new PaymentMethodResponseDto
            {
                PaymentMethodId = pm.PaymentMethodId,
                PaymentMethodName = pm.PaymentMethodName,
                Description = pm.Description,
                IsActive = pm.IsActive,
                CreateDate = pm.CreateDate
            });
        }
    }
}
