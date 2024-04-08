using DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Command.Application.Interfaces.ServiceInterfaces
{
    public interface IProductCommandService
    {
        Task<ProductDto> Create();
        Task<ProductDto> Update();
    }
}
