﻿using System.ComponentModel.DataAnnotations;

namespace VoluntraGProject.Models.ViewModels
{
    public class EditRoleViewModel
    {
        public string RoleId { get; set; } //PK
        [Required]
        public string RoleName { get; set; }
      
    }
}
