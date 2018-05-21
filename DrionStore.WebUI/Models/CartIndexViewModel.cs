using DrionStore.Domain.Entities;

namespace DrionStore.WebUI.Models
{
    public class CartIndexViewModel
    {
        // object to retain cart and url info.
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}