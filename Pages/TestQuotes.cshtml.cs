using HealthInsuranceWeb.Data;
using HealthInsuranceWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HealthInsuranceWeb.Pages
{
    public class TestQuotesModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public TestQuotesModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<QuoteRequest> Quotes { get; set; } = new();

        public async Task OnGetAsync()
        {
            Quotes = await _context.QuoteRequests.ToListAsync();
        }
    }
}
