using DTOs.Product;
using Product.Command.Application.Interfaces.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Command.Application.Services
{
    public class ProductCommandService : IProductCommandService
    {
        public Task<ProductDto> Create()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> Update()
        {
            throw new NotImplementedException();
        }
    }
}
