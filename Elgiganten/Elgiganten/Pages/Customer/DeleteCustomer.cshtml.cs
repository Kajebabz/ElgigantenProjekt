using Elgiganten.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elgiganten.Pages.Customer
{
    public class DeleteCustomerModel : PageModel
    {
        private ICustomerService _customerService;

        [BindProperty]
        public Models.Customer Customer { get; set; }

        public DeleteCustomerModel(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult OnGet(int id)
        {
            Customer = _customerService.GetCustomer(id);
            if (Customer == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return Page();
        }

        public IActionResult OnPost()
        {
            Models.Customer deletedCustomer = _customerService.DeleteCustomer(Customer.Id);
            if (deletedCustomer == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu
            return RedirectToPage("GetAllCustomer");
        }
    }
}
