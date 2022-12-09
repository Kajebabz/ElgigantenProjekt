using Elgiganten.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elgiganten.Pages.Customer
{
    public class GetAllCustomerModel : PageModel
    {
        [BindProperty] public string SearchString { get; set; }

        private ICustomerService _customerService;

        public GetAllCustomerModel(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public List<Models.Customer> _customers { get; private set; }


        public IActionResult OnGet()
        {
            _customers = _customerService.GetCustomers().ToList();
            return Page();
        }

        public IActionResult OnPostNameSearch()
        {
            _customers = _customerService.NameSearch(SearchString).ToList();
            return Page();
        }
    }
}
