using System.ComponentModel.DataAnnotations.Schema;

namespace VoluntraGProject.Models
{
	public class NGO
	{
		public int NGOId { get; set; }
		public string NGOName { get; set; }
		public string Description { get; set; }
		public string? Image { get; set; }
		[NotMapped]
		public IFormFile ImageFile { get; set; }
	}
}

