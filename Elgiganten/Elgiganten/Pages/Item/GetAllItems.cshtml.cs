using Elgiganten.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elgiganten.Pages.Item
{
    public class GetAllItemsModel : PageModel
    {
        [BindProperty] public string SearchString { get; set; }
        [BindProperty] public int MinPrice { get; set; }
        [BindProperty] public int MaxPrice { get; set; }

        private IItemService _itemService;

        public GetAllItemsModel(IItemService itemService)
        {
            _itemService = itemService;
        }

        public List<Models.Item> Items { get; private set; }


        public IActionResult OnGet()
        {
            Items = _itemService.GetItems().ToList();
            return Page();
        }

        public IActionResult OnPostNameSearch()
        {
            Items = _itemService.NameSearch(SearchString).ToList();
            return Page();
        }
        public IActionResult OnPostPriceFilter(int maxPrice, int minPrice = 0)
        {
            Items = _itemService.PriceFilter(maxPrice, minPrice).ToList();
            return Page();
        }
    }
}
