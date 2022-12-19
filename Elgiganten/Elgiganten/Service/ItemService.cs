using Elgiganten.Models;
using Elgiganten.Pages.Item;

namespace Elgiganten.Service
{
    public class ItemService : IItemService
    {
        private List<Item> items;
        private JsonFileItemService JsonFileItemService { get; set; }

        public ItemService(JsonFileItemService jsonFileItemService)
        {
             JsonFileItemService = jsonFileItemService;
             // items = MockData.MockItems.GetMockItems();
             items = JsonFileItemService.GetJsonItems().ToList();
             Item.nextId = items[^1].Id + 1;
        }


        public List<Item> GetItems()
        {
            return items;
        }
        public void AddItem(Item item)
        {
            item.Id = Item.nextId++;
            items.Add(item);
            JsonFileItemService.SaveJsonItems(items);
        }
        // Bruger nu SearchAll istedet.

        //public IEnumerable<Item> NameSearch(string str)
        //{
        //    List<Item> nameSearch = new List<Item>();
        //    foreach (Item item in items)
        //    {
        //        if (item.Name.ToLower().Contains(str.ToLower()))
        //        {
        //            nameSearch.Add(item);
        //        }
        //    }
        //    return nameSearch;
        //}

        //public IEnumerable<Item> TypeSearch(string str)
        //{
        //    List<Item> typeSearch = new List<Item>();
        //    foreach (Item item in items)
        //    {
        //        if (item.Type.ToLower().Contains(str.ToLower()))
        //        {
        //            typeSearch.Add(item);
        //        }
        //    }
        //    return typeSearch;
        //}

        //    public IEnumerable<Item> PriceFilter(int maxPrice, int minPrice = 0)
        //{
        //    List<Item> filterList = new List<Item>();
        //    foreach (Item item in items)
        //    {
        //        if (item.Price>=minPrice && item.Price<=maxPrice)
        //        {
        //            filterList.Add(item);
        //        }
        //    }
        //    return filterList;
        //}

  
        public void UpdateItem(Item item)
        {
            if (item != null)
            {
                foreach (Item i in items)
                {
                    if (i.Id == item.Id)
                    {
                        i.Type = item.Type;
                        i.Name = item.Name;
                        i.Brand = item.Brand;
                        i.Description = item.Description;
                        i.Price = item.Price;
                    }
                }
                JsonFileItemService.SaveJsonItems(items);
            }
        }
        public Item GetItem(int id)
        {
            foreach (Item item in items)
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }
        public Item DeleteItem(int? itemId)
        {
            Item itemToBeDeleted = null;
            foreach (Item i in items)
            {
                if (i.Id == itemId)
                {
                    itemToBeDeleted = i;
                    break;
                }
            }
            if (itemToBeDeleted != null)
            {
                items.Remove(itemToBeDeleted);
                JsonFileItemService.SaveJsonItems(items);
            }
            return itemToBeDeleted;
        }
        public IEnumerable<Item> SearchAll(string name, string type, int minPrice, int maxPrice)
        {
            List<Item> SearchResult = new List<Item>();
            foreach (Item item in items)
            {
                if (name == null || item.Name.ToLower().Contains(name.ToLower()))
                {
                    if (type == "ShowAll" || item.Type.ToLower().Contains(type.ToLower()))
                    {
                        if (item.Price >= minPrice && item.Price <= maxPrice || minPrice == 0 && maxPrice == 0)
                        {
                            SearchResult.Add(item);
                        }
                    }
                }
            }
            return SearchResult;
        }

    }
}
