using System.Collections.Generic;
using DrionStore.Domain.Entities;

namespace DrionStore.Domain.Abstract
{
    /// <summary>
    /// Interface for getting product entites from database
    /// </summary>
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
