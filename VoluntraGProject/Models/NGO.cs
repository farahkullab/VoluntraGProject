using System.ComponentModel.DataAnnotations.Schema;

namespace VoluntraGProject.Models
{
	public class NGO
	{
		public int NGOId { get; set; }
		public string NGOName { get; set; }
		public string Description { get; set; }
		public string PhoneNumber { get; set; }
		public string Address { get; set; }
		public string Type { get; set; } 
		public string? Image { get; set; }
		[NotMapped]
		public IFormFile ImageFile { get; set; }
	}
}

