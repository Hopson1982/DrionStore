using DrionStore.Domain.Entities;
using System.Data.Entity;

namespace DrionStore.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
