using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Application.Interfaces.RepositoryInterfaces
{
    public interface IUnitOfWork
    {
        IProductCommandRepository ProductCommandRepository { get; }
        Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
