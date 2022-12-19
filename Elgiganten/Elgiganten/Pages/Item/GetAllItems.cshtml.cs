using Elgiganten.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elgiganten.Pages.Item
{
    public class GetAllItemsModel : PageModel
    {
        [BindProperty] public string SearchString { get; set; }
        [BindProperty] public string SearchStringType { get; set; }
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

        public IActionResult OnPostSearchAll()
        {
            Items = _itemService.SearchAll(SearchString, SearchStringType, MinPrice, MaxPrice).ToList();
            return Page();
        }
    }
}
