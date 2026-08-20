using SalesManagement.Aggregators.PaymentMethods;
using SalesManagement.DTOs.Commands;
using SalesManagement.DTOs.Responses.PaymentMethods;
using SalesManagement.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.Handler.Commands.PaymentMethods
{
    public class CreatePaymentMethodHandler
    {

        private readonly IPaymentMethodRepository _repository;

        public CreatePaymentMethodHandler(IPaymentMethodRepository repository)
        {
            _repository = repository;
        }

        public async Task<PaymentMethodResponseDto> Handle(
            CreatePaymentMethodCommand command)
        {
            var paymentMethod = PaymentMethod.Create(
                command.PaymentMethodName,
                command.Description,
                command.IsActive);

    
            await _repository.AddAsync(paymentMethod);

            await _repository.SaveAsync();

            return new PaymentMethodResponseDto
            {
                PaymentMethodId = paymentMethod.PaymentMethodId,
                PaymentMethodName = paymentMethod.PaymentMethodName,
                Description = paymentMethod.Description,
                IsActive = paymentMethod.IsActive,
                CreateDate = paymentMethod.CreateDate
            };
        }
    }
}
