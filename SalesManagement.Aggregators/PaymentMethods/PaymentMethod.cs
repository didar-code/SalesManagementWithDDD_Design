using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.Aggregators.PaymentMethods
{
    public class PaymentMethod
    {
        public int PaymentMethodId { get; private set; }
        public string PaymentMethodName { get; private set; } = string.Empty;
        public string? Description { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime CreateDate { get; private set; }
        private PaymentMethod()
        {

        }
        public static PaymentMethod Create(string paymentMethodName, string? description, bool isActive)
        {
            if (string.IsNullOrWhiteSpace(paymentMethodName))
            {
                throw new ArgumentException("Payment method name cannot be null or empty.", nameof(paymentMethodName));
            }
            var paymentMethod = new PaymentMethod
            {
                PaymentMethodName = paymentMethodName,
                Description = description,
                IsActive = isActive,
                CreateDate = DateTime.UtcNow
            };
            return paymentMethod;
        }
    }
}
