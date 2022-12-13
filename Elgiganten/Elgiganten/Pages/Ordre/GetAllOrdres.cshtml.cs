using Elgiganten.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elgiganten.Pages.Ordre
{
    public class GetAllOrdresModel : PageModel
    {
       

        private OrdreService _ordreService;

        public GetAllOrdresModel(OrdreService ordreService)
        {
            _ordreService = ordreService;
        }

        public List<Models.Ordre> Ordres { get; private set; }


        public IActionResult OnGet()
        {
            Ordres = _ordreService.GetOrdres().ToList();
            return Page();
        }
    
    }
    
}
