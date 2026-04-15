using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace HealthInsuranceWeb.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public ContactInput Input { get; set; } = new();

        public string Message { get; set; } = string.Empty;

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            Message = "Thank you for contacting us. Our team will get back to you shortly.";
            ModelState.Clear();
            Input = new ContactInput();
        }

        public class ContactInput
        {
            [Required]
            public string Name { get; set; } = string.Empty;

            [Required]
            [EmailAddress]
            public string Email { get; set; } = string.Empty;

            [Required]
            public string Subject { get; set; } = string.Empty;

            [Required]
            public string MessageText { get; set; } = string.Empty;
        }
    }
}