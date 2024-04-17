using Command.Application.Command;
using DTOs.Common;
using DTOs.Product;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Command.API.Controllers
{
    
    [ApiController]
    [Route("api/v{version:apiVersion}/Product")]
    [ApiVersion("1")]
    public class ProductController : ControllerBase
    {
        private ILogger<ProductController> _logger;
        private readonly ISender _sender;
        public ProductController(ILogger<ProductController> logger, ISender sender)
        {
            _logger = logger;
            _sender = sender;
        }

        [HttpPost]
        public async Task<ResponseDto> Add([FromBody] ProductDto productDto)
        {
            var command= new CreateProductCommand(productDto);
            return await _sender.Send(command);
        }
    }
}
