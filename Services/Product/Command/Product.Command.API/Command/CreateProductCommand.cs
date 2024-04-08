using DTOs.Product;
using MediatR;

namespace Product.Command.API.Command
{
    public class CreateProductCommand: IRequest<ProductDto>
    {
    }
}
