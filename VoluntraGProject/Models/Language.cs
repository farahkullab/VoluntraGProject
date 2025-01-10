using System.ComponentModel.DataAnnotations;

namespace VoluntraGProject.Models
{
	public class Language
	{
		public int LanguageID { get; set; }
		[Required]
		public string Key { get; set; }
		[Required]
		[MaxLength(10)]
		public string LanguageCode { get; set; }
		public string Translation { get; set; }

	}
}