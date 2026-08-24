using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesManagement.DTOs.Responses;
using SalesManagement.Shared;

namespace SalesManagement.DTOs.Queries
{
    public class SearchPaymentMethodQuery: IQuery<IEnumerable<PaymentMethodResponseDto>>
    {
        public string? Name { get; set; }

        public bool? IsActive { get; set; }
    }
}
