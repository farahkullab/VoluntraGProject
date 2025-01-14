using System.ComponentModel.DataAnnotations.Schema;

namespace VoluntraGProject.Models
{
	public class Event
	{
		public int EventId { get; set; }
		public int NGOId { get; set; }
		public string EventName { get; set; }
		public string EventDescription { get; set; }
		public DateTime EventDate { get; set; }
		public string Location { get; set; }
		public string? Image { get; set; }
		[NotMapped]
		public IFormFile ImageFile { get; set; }
    }

}
