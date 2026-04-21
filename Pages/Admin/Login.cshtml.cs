using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace HealthInsuranceWeb.Pages.Admin
{
    public class LoginModel : PageModel
    {
        
        [BindProperty]
        public LoginInput Input { get; set; } = new();

        public string ErrorMessage { get; set; } = string.Empty;

        public class LoginInput
        {
            [Required]
            public string Username { get; set; } = string.Empty;

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; } = string.Empty;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // Test only
            var adminUsername = "admin";
            var adminPassword = "12345";

            if (Input.Username == adminUsername && Input.Password == adminPassword)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, Input.Username),
                    new Claim(ClaimTypes.Role, "Admin")
                };

                var identity = new ClaimsIdentity(
                    claims,
                    CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    principal);

                return RedirectToPage("/Admin/TestQuotes");
            }

            ErrorMessage = "Invalid username or password.";
            return Page();
        }
    }
}
