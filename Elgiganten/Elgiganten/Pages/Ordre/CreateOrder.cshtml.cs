using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Elgiganten.Pages.Ordre;
using global::Elgiganten.Service;
using Elgiganten.Pages.Ordre.CreateOrderModel;

namespace Elgiganten.Pages.Ordre.CreateOrderModel
{

    public class CreateOrdreModel : PageModel
    {

        private IOrdreService _ordreService;
        private IItemService _itemService;
        private ICustomerService _customerService;

        public CreateOrdreModel(IOrdreService ordreService, IItemService itemService, ICustomerService customerService)
        {
            _ordreService = ordreService;
            _itemService = itemService;
            _customerService = customerService;
        }
        [BindProperty]
        public Models.Ordre ordre { get; set; }
        [BindProperty]
        public int CustomerID { get; set; }
        [BindProperty]
        public int ItemID { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            ordre.Item = _itemService.GetItem(ItemID);
            ordre.Customer = _customerService.GetCustomer(CustomerID);
            _ordreService.AddOrdre(ordre);
            return RedirectToPage("GetAllOrdres");
        }
    }

}
