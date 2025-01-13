using System.ComponentModel.DataAnnotations;

namespace VoluntraGProject.Models.ViewModels
{
    public class RegisterViewModel
    {
        public string? NGOName { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "PASSWORD AND CONFIEM NOT MATCH")]
        public string ConfirmPassword { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
    }

}
