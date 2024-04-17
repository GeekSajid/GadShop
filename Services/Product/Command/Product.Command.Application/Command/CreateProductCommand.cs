using DTOs.Common;
using DTOs.Product;
using MediatR;

namespace Command.Application.Command
{
    public class CreateProductCommand: IRequest<ResponseDto>
    {
        public ProductDto Product { get; }
        public CreateProductCommand(ProductDto productDto)
        {
            Product = productDto;
        }
    }
}
