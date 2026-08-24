using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesManagement.DTOs.Commands;
using SalesManagement.DTOs.Queries;
using SalesManagement.DTOs.Responses;
using SalesManagement.Shared.Generics;
using System.Reflection.Metadata;


namespace SalesManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentMethodController : ControllerBase
    {

        private readonly ICommandHandler<CreatePaymentMethodCommand, PaymentMethodResponseDto> _createHandler;
        private readonly IQueryHandler<SearchPaymentMethodQuery, IEnumerable<PaymentMethodResponseDto>> _searchHandler;

        public PaymentMethodController(ICommandHandler<CreatePaymentMethodCommand, PaymentMethodResponseDto> createHandler, 
            IQueryHandler<SearchPaymentMethodQuery, IEnumerable<PaymentMethodResponseDto>> searchHandler)
        {
           _createHandler = createHandler;
            _searchHandler = searchHandler;
        }

        [HttpPost]
        public async Task<IActionResult> Create( CreatePaymentMethodCommand command)
        {
            var result = await _createHandler.HandleAsync(command);

            return Ok(result);
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search([FromQuery] SearchPaymentMethodQuery query)
        {
            var result = await _searchHandler.HandleAsync(query);

            return Ok(result);
        }
    }
}
