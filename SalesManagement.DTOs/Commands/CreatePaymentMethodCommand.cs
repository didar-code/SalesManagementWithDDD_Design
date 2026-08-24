using SalesManagement.DTOs.Responses;
using SalesManagement.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SalesManagement.DTOs.Commands
{
    public class CreatePaymentMethodCommand : ICommand<PaymentMethodResponseDto>
    {
        public string PaymentMethodName { get; set; } = string.Empty;

        public string? Description { get; set; }

        public bool IsActive { get; set; }
    }
}
