namespace VoluntraGProject.Models
{
	public class Feedback
	{
		public int FeedbackID { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }	
		public string Subject { get; set; }
		public string Message { get; set; }

		//public int VolunteerID { get; set; } as FK لبمفروض هد بدل الاسم 
	}
}
