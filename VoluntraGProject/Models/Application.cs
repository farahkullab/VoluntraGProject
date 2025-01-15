using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VoluntraGProject.Models
{
    public class Application
    {
        public int ApplicationId { get; set; }
        [ForeignKey("Event")]
        [Required]
        public int? EventId { get; set; }
        public string VolunteerName { get; set; }
        public string Email { get; set; }
        public string skills { get; set; }
        public string Experince { get; set; }
        public DateOnly AppliedDate { get; set; }
    }
}
