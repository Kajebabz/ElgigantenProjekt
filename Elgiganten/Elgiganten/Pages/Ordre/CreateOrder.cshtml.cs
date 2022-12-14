using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Elgiganten.Pages.Ordre;
using global::Elgiganten.Service;
using Elgiganten.Pages.Ordre.CreateOrderModel;

namespace Elgiganten.Pages.Ordre.CreateOrderModel
{
   
        public class CreateOrdreModel : PageModel
        {

            private OrdreService _ordreService;

            public CreateOrdreModel(OrdreService ordreService)
            {
                _ordreService = ordreService;
            }

            [BindProperty]
            public Models.Ordre ordre { get; set; }


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
                _ordreService.AddOrdre(ordre);
                return RedirectToPage("GetAllOrdres");
            }
        }
    
}
