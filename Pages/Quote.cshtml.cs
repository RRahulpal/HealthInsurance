using HealthInsuranceWeb.Data;
using HealthInsuranceWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.ComponentModel.DataAnnotations;

namespace HealthInsuranceWeb.Pages
{
    public class QuoteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public QuoteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public QuoteInput Input { get; set; } = new();

        public string SuccessMessage { get; set; } = string.Empty;

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // ✅ Save to DB
            var quote = new QuoteRequest
            {
                FullName = Input.FullName,
                Age = Input.Age,
                City = Input.City,
                Mobile = Input.Mobile,
                Email = Input.Email,
                PlanType = Input.PlanType,
                CreatedAt = DateTime.Now
            };

            _context.QuoteRequests.Add(quote);
            await _context.SaveChangesAsync();

            SuccessMessage = $"Thank you {Input.FullName}, your quote request has been submitted successfully.";

            ModelState.Clear();
            Input = new QuoteInput();

            return Page();
        }

        public class QuoteInput
        {
            [Required]
            [StringLength(100)]
            public string FullName { get; set; } = string.Empty;

            [Required]
            [Range(18, 100)]
            public int Age { get; set; }

            [Required]
            public string City { get; set; } = string.Empty;

            [Required]
            public string Mobile { get; set; } = string.Empty;

            [Required]
            [EmailAddress]
            public string Email { get; set; } = string.Empty;

            [Required]
            public string PlanType { get; set; } = string.Empty;
        }
    }
}