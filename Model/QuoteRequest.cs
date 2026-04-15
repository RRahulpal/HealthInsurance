using System.ComponentModel.DataAnnotations;

namespace HealthInsuranceWeb.Model
{
    public class QuoteRequest
    {
       
            public int Id { get; set; }

            [Required]
            [StringLength(100)]
            public string FullName { get; set; } = string.Empty;

            [Required]
            public int Age { get; set; }

            [Required]
            public string City { get; set; } = string.Empty;

            [Required]
            public string Mobile { get; set; } = string.Empty;

            [Required]
            public string Email { get; set; } = string.Empty;

            [Required]
            public string PlanType { get; set; } = string.Empty;

            public DateTime CreatedAt { get; set; } = DateTime.Now;
        }
    
}

