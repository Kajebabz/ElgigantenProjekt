using Elgiganten.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elgiganten.Pages.Customer
{
    public class CreateCustomerModel : PageModel
    {
        private ICustomerService _customerservice;

        public CreateCustomerModel(ICustomerService customerService)
        {
            _customerservice = customerService;
        }

        [BindProperty]
        public Models.Customer customer { get; set; }


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
            _customerservice.AddCustomer(customer);
            return RedirectToPage("GetAllCustomer");
        }
    }
}
