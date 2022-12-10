using Elgiganten.Models;

namespace Elgiganten.Service
{
    public interface IShoppingCartService
    {

        List<ShoppingCart> GetShoppingCarts();
        void AddShoppingCart(ShoppingCart shoppingCart);
        void UpdateShoppingCart(ShoppingCart shoppingCart);
        ShoppingCart GetShoppingCart(int id);
        ShoppingCart DeleteShoppingCart(int? shoppingCartId);
        IEnumerable<ShoppingCart> NameSearch(string str);
        IEnumerable<ShoppingCart> PriceFilter(int maxPrice, int minPrice = 0);
    }

}
