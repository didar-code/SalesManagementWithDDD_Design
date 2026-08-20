using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.DTOs.Responses.PaymentMethods
{
    public class PaymentMethodResponseDto
    {
        public int PaymentMethodId { get; set; }

        public string PaymentMethodName { get; set; } = string.Empty;

        public string? Description { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
