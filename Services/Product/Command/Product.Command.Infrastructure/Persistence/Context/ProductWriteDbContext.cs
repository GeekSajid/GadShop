using Microsoft.EntityFrameworkCore;
using Command.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Infrastructure.Persistence.Context
{
    public class ProductWriteDbContext : DbContext
    {
        public ProductWriteDbContext(DbContextOptions<ProductWriteDbContext> options)
    : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
