using DTOs.Product;
using MediatR;
using Command.Application.Command;
using Command.Application.Interfaces.RepositoryInterfaces;
using FluentValidation;
using Command.Domain.Entity;
using DTOs.Common;

namespace Command.Application.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ResponseDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<CreateProductCommand> _productValidator;
        public CreateProductCommandHandler(
            IUnitOfWork unitOfWork,
            IValidator<CreateProductCommand> productValidator)
        {
            _unitOfWork = unitOfWork;
            _productValidator = productValidator;
        }
        public async Task<ResponseDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var result = await _productValidator.ValidateAsync(request);
            var response = new ResponseDto();
            if (!result.IsValid)
            {
                var errorMessage = string.Join(", ", result.Errors.Select(e => e.ErrorMessage));
                response.IsSuccess = false;
                response.Message = errorMessage;
                return response;
            }
            _unitOfWork.ProductCommandRepository.Create(request.Product);
            if (await _unitOfWork.SaveChangesAsync(cancellationToken))
            {
                response.Result = request.Product;
                response.IsSuccess = true;
                response.Message = "Product Created successfully";
                return response;
            }
            response.IsSuccess = false;
            response.Message = "Something went wrong! Please try again";
            return response;
        }
    }
}
