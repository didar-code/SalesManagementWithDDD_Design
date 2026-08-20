using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.DTOs.Queries
{
    public class SearchPaymentMethodQuery
    {
        public string? Name { get; set; }

        public bool? IsActive { get; set; }
    }
}
