using Command.Application.Interfaces.RepositoryInterfaces;
using Command.Infrastructure.Persistence.Context;
using DTOs.Common;
using DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Infrastructure.Persistence.Repositories
{
    public class ProductCommandRepository : IProductCommandRepository
    {
        private readonly ProductWriteDbContext _dbContext;

        public ProductCommandRepository(ProductWriteDbContext dbContext) => _dbContext = dbContext;
        public async void Create(ProductDto productDto)
        {
            await _dbContext.AddAsync(productDto);
        }

        public void Update(ProductDto productDto)
        {
            throw new NotImplementedException();
        }
    }
}
