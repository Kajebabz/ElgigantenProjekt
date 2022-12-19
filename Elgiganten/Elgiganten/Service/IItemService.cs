using Elgiganten.Models;
using Elgiganten.Pages.Item;

namespace Elgiganten.Service
{
    public interface IItemService
    {
        List<Item> GetItems();
        void AddItem(Item item);
        void UpdateItem(Item item);
        Item GetItem(int id);
        Item DeleteItem(int? itemId);
        // Bruger nu SearchAll istedet. 
        //IEnumerable<Item> NameSearch(string str);
        //IEnumerable<Item> TypeSearch(string str);
        //IEnumerable<Item> PriceFilter(int maxPrice, int minPrice = 0);
        IEnumerable<Item> SearchAll(string name, string type, int minPrice, int maxPrice);
    }
}
