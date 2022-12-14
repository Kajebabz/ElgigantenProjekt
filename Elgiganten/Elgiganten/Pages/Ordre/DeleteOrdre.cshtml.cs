using Elgiganten.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Elgiganten.Pages.Ordre.DeleteOrderModel;

namespace Elgiganten.Pages.Ordre.DeleteOrderModel
{
    public class DeleteOrdreModel : PageModel
    {
      
            
        private OrdreService _ordreService;

        [BindProperty]
        public Models.Ordre Ordre { get; set; }

        public DeleteOrdreModel(OrdreService ordreService)
        {
            _ordreService = ordreService;
        }

        public IActionResult OnGet(int id)
        {
            Ordre = _ordreService.GetOrdre(id);
            if (Ordre == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return Page();
        }

        public IActionResult OnPost()
        {
            Models.Ordre deletedordre = _ordreService.DeleteOrdre(Ordre.Id);
            if (deletedordre == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu
            return RedirectToPage("GetAllItems");
        }
    }
}

  
