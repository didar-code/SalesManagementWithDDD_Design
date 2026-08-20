using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesManagement.DTOs.Commands;
using SalesManagement.DTOs.Queries;
using SalesManagement.Handler.Commands.PaymentMethods;
using SalesManagement.Handler.Queries.PaymentMethods;

namespace SalesManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentMethodController : ControllerBase
    {
        private readonly CreatePaymentMethodHandler _createHandler;
        private readonly SearchPaymentMethodHandler _searchHandler;

        public PaymentMethodController( CreatePaymentMethodHandler createHandler, SearchPaymentMethodHandler searchHandler)
        {
            _createHandler = createHandler;
            _searchHandler = searchHandler;
        }

        [HttpPost]
        public async Task<IActionResult> Create( CreatePaymentMethodCommand command)
        {
            var result = await _createHandler.Handle(command);

            return Ok(result);
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search([FromQuery] SearchPaymentMethodQuery query)
        {
            var result = await _searchHandler.Handle(query);

            return Ok(result);
        }
    }
}
