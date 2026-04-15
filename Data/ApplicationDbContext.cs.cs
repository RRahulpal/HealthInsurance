using HealthInsuranceWeb.Model;
using Microsoft.EntityFrameworkCore;

namespace HealthInsuranceWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<QuoteRequest> QuoteRequests { get; set; }
    }
}
