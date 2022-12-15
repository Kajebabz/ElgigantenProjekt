using Elgiganten.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elgiganten.Pages.Ordre
{
    public class EditOrdreModel : PageModel
    {
        [BindProperty]
        public Models.Ordre ordre { get; set; }

        private IOrdreService _ordreService;

        public EditOrdreModel(IOrdreService ordreService)
        {
            _ordreService = ordreService;
        }

      

        public IActionResult OnGet(int id)
        {
            ordre = _ordreService.GetOrdre(id);
            if (ordre == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _ordreService.UpdateOrdre(ordre);
            return RedirectToPage("GetAllOrdres");
        }
    }
}

