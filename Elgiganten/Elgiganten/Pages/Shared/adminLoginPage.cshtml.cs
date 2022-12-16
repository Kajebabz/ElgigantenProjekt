using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elgiganten.Pages.Shared
{
   
        public class adminLoginPageModel : PageModel
        {
            private readonly ILogger<PrivacyModel> logger;
            public adminLoginPageModel(ILogger<PrivacyModel> logger)
            {
                this.logger = logger;
            }
            public void OnGet()
            {

            }
        }
    }



