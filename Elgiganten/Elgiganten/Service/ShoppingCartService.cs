using Elgiganten.Models;

namespace Elgiganten.Service
{
    public class ShoppingCartService : IShoppingCartService
    {
        private List<ShoppingCart> shoppingCarts;

        private JsonFileShoppingCart JsonFileShoppingCartService { get; set; }

        public ShoppingCartService (JsonFileShoppingCart jsonFileShoppingCartservice)
        {
            JsonFileShoppingCartService = JsonFileShoppingCartService;
            //customers = MockCustomers.GetMockCustomers();
            shoppingCarts = JsonFileShoppingCart.GetJsonShoppingCarts().ToList();
        }

        public List<ShoppingCart> GetShoppingCart()
        {
            return shoppingCarts;
        }

        public void AddShoppingCart(ShoppingCart shoppingCart)
        {
            shoppingCarts.Add(shoppingCart);
            JsonFileShoppingCart.SaveJsonShoppingCart(shoppingCarts);
        }

        public IEnumerable<ShoppingCart> NameSearch(string str)
        {
            List<ShoppingCart> nameSearch = new List<ShoppingCart>();
            foreach (ShoppingCart shoppingCart in shoppingCarts)
            {
                if (shoppingCart.Name.ToLower().Contains(str.ToLower()))
                {
                    nameSearch.Add(shoppingCart);
                }
            }
            return nameSearch;
        }

        public void UpdateShoppingCart(ShoppingCart shoppingCart)
        {
            if (shoppingCart != null)
            
                foreach (ShoppingCart i in shoppingCarts)
                {
                    if (i.Id == shoppingCart.Id)
                    {
                        i.Name = shoppingCart.Name;
                        i.Address = shoppingCart.Address;
                        i.PhoneNr = shoppingCart.PhoneNr;
                        i.Email = shoppingCart.Email;

                    }
                }
                JsonFileShoppingCart.SaveJsonJsonFileShoppingCart(shoppingCarts);
            }
        }
        public ShoppingCart GetShoppingCart(int id)
        {
            foreach (ShoppingCart shoppingCart in shoppingCarts)
            {
                if (shoppingCart.Id == id)
                    return shoppingCart;
            }
            return null;
        }
        public ShoppingCart DeleteShoppingCart(int? ShoppingCartId)
        {
            ShoppingCart shoppingCartToBeDeleted = null;
            foreach (ShoppingCart i in shoppingCarts)
            {
                if (i.Id == CustomerId)
                {
                    shoppingCartToBeDeleted = i;
                    break;
                }
            }
            if (shoppingCartToBeDeleted != null)
            {
                shoppingCarts.Remove(shoppingCartToBeDeleted);
                JsonFileShoppingCart.SaveJsonShoppingCarts(shoppingCarts);
            }
            return shoppingCartToBeDeleted;
        }

        public List<ShoppingCart> GetShoppingCarts()
        {
            throw new NotImplementedException();
        }

        public void AddShoppingCart(ShoppingCart shoppingCart)
        {
            throw new NotImplementedException();
        }

        public void UpdateShoppingCart(ShoppingCart shoppingCart)
        {
            throw new NotImplementedException();
        }

        public ShoppingCart GetShoppingCart(int id)
        {
            throw new NotImplementedException();
        }

        public ShoppingCart DeleteShoppingCart(int? shoppingCartId)
        {
            throw new NotImplementedException();
        }

        IEnumerable<ShoppingCart> IShoppingCartService.NameSearch(string str)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShoppingCart> PriceFilter(int maxPrice, int minPrice = 0)
        {
            throw new NotImplementedException();
        }
    }
}