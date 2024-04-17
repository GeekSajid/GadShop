using Command.Application.Interfaces.RepositoryInterfaces;
using Command.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Infrastructure.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProductWriteDbContext _writeContext;
        public UnitOfWork(ProductWriteDbContext writeContext)
        {
            _writeContext = writeContext;
        }

        public IProductCommandRepository ProductCommandRepository => new ProductCommandRepository(_writeContext);

        public async Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _writeContext.SaveChangesAsync(true) > 0;
        }
    }
}
