using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elgiganten.Pages.Shared
{
    public class mainStorePageModel : PageModel
    {
        private readonly ILogger<mainStorePageModel> logger;
        public mainStorePageModel(ILogger<mainStorePageModel> logger)
        {
            this.logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
