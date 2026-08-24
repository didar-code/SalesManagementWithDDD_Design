using SalesManagement.Aggregators.Mapper;
using SalesManagement.Aggregators.PaymentMethods;
using SalesManagement.DTOs.Commands;
using SalesManagement.DTOs.Responses;
using SalesManagement.Repository.Interfaces;
using SalesManagement.Shared.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.Handler.Commands
{
    public class CreatePaymentMethodHandler : ICommandHandler<CreatePaymentMethodCommand, PaymentMethodResponseDto>
    {
        private readonly IPaymentMethodRepository _repository;

        public CreatePaymentMethodHandler(IPaymentMethodRepository repository)
        {
            _repository = repository;
        }

        public async Task<PaymentMethodResponseDto> HandleAsync(CreatePaymentMethodCommand command)
        {
            var paymentMethod = PaymentMethodAggregatorsRoot.Create(
                command.PaymentMethodName,
                command.Description,
                command.IsActive);

            await _repository.AddAsync(paymentMethod);
            await _repository.SaveAsync();

            //return PaymentMethodMapper.ToResponse(paymentMethod);
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
