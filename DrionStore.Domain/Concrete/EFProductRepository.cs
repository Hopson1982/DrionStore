using DrionStore.Domain.Abstract;
using DrionStore.Domain.Entities;
using System.Collections.Generic;

namespace DrionStore.Domain.Concrete
{
    // class to create product repository
    public class EFProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}