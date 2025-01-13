namespace VoluntraGProject.Models
{
    public class Application
    {
        public int ApplicationId { get; set; }
        public int VolunteerId { get; set; }
        public int EventId  { get; set; }
        public string Status { get; set; }
        public DateOnly AppliedDate { get; set; }
    }
}
