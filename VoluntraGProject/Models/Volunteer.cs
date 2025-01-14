using System.ComponentModel.DataAnnotations.Schema;

namespace VoluntraGProject.Models
{
    public class Volunteer
    {
        public int VolunteerId { get; set; }
        [ForeignKey("Event")]
        public int EventId { get; set; }
        public string VolunteerName { get; set; }
        public string Email { get; set; }
        public string skills { get; set; }
        public string Experince { get; set; }
    }
}

//}  يمكن امسحه هاد المودل 
