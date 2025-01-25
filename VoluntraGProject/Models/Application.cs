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
        public string Experience { get; set; }
        public DateOnly AppliedDate { get; set; }
        public bool TravelingAbility { get; set; }
        public string Age { get; set; }
        public string YearsOfExperience { get; set; }
        public string Yourfield { get; set; }
        public bool IsExpereinced { get; set; }
        public string Location { get; set; }
    }
}

