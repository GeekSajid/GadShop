using DTOs.Common;
using DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Application.Interfaces.RepositoryInterfaces
{
    public interface IProductCommandRepository
    {
        void Create(ProductDto productDto);
        void Update(ProductDto productDto);
    }
}
