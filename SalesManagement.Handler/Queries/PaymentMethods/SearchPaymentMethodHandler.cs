using SalesManagement.Aggregators.Mapper;
using SalesManagement.DTOs.Queries;
using SalesManagement.DTOs.Responses.PaymentMethods;
using SalesManagement.Handler.Interfaces;
using SalesManagement.Repository.Data;
using SalesManagement.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.Handler.Queries.PaymentMethods
{
    public class SearchPaymentMethodHandler:ISearchPaymentMethodHandler
    {
        private readonly IPaymentMethodRepository _repository;

        public SearchPaymentMethodHandler(IPaymentMethodRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<PaymentMethodResponseDto>> Handle(SearchPaymentMethodQuery query)
        {
            var paymentMethods = await _repository.SearchAsync(query.Name, query.IsActive);

            return PaymentMethodMapper.ToResponseList(paymentMethods);
        }
    }
}
