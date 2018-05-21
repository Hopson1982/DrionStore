using System.Collections.Generic;
using DrionStore.Domain.Entities;

namespace DrionStore.WebUI.Models
{
    // class for sending data to the view
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}