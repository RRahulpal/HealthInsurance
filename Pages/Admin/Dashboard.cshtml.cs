using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HealthInsuranceWeb.Pages.Admin
{
   
        [Authorize(Roles = "Admin")]
        public class DashboardModel : PageModel
        {
            public void OnGet()
            {
            }
        }
    
}
