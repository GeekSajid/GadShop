using DTOs.Product;
using MediatR;
using Product.Command.API.Command;

namespace Product.Command.API.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ProductDto>
    {
        public Task<ProductDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
