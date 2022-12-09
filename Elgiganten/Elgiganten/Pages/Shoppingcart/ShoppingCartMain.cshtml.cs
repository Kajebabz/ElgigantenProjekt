using Elgiganten.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Elgiganten.Models.CartItem;

namespace Elgiganten.Pages.Shoppingcart
{
    public class ShoppingCartMainModel : PageModel
    {
        public List<CartItem> Cart { get; set; }
        public decimal TotalPrice { get; set; }

        public void OnPost(string remove, string clear)
        {   
            if (!string.IsNullOrEmpty(remove))
            {
                // Remove the specified item from the cart
                RemoveFromCart(int.Parse(remove));
            }
            else if (!string.IsNullOrEmpty(clear))
            {
                // Clear the cart
                Cart.Clear();
            }
        }

        private void AddToCart(int itemId, int quantity, decimal price)
        {
            var cartItem = Cart.FirstOrDefault(i => i.Id == itemId);
            if (cartItem != null)
            {
                // Update the existing item in the cart
                cartItem.Quantity += quantity;
            }
            else
            {
                // Add a new item to the cart
                Cart.Add(new CartItem
                {
                    Id = itemId,
                    Name = "Item " + itemId,
                    Quantity = quantity,
                    Price = price
                });
            }

            // Update the total price of the items in the cart
            TotalPrice = Cart.Sum(i => i.Price * i.Quantity);
        }

        private void RemoveFromCart(int itemId)
        {
            var cartItem = Cart.FirstOrDefault(i => i.Id == itemId);
            if (cartItem != null)
            {
                // Remove the item from the cart
                Cart.Remove(cartItem);

                // Update the total price of the items in the cart
                TotalPrice = Cart.Sum(i => i.Price * i.Quantity);
            }
        }
    }

}

