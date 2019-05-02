﻿using System.ComponentModel.DataAnnotations;

namespace Wuwee.MvcWebUI.ViewModels
{
    public class AddRoleViewModel
    {
        [Required]
        [Display(Name = "Role name")]
        public string RoleName { get; set; }
    }
}