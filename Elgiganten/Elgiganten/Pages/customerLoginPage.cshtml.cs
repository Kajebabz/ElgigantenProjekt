using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elgiganten.Pages
{
    public class customerLoginPageModel : PageModel
    {
        private readonly ILogger<PrivacyModel> logger;
        public customerLoginPageModel(ILogger<PrivacyModel> logger)
        {
            this.logger = logger;
        }
        public void OnGet()
        {
        }
    }
}

