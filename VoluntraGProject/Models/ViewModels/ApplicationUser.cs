using Microsoft.AspNetCore.Identity;

namespace VoluntraGProject.Models.ViewModels
{
    public class ApplicationUser : IdentityUser
    {
        public string NGOName { get; internal set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }

    }
}

