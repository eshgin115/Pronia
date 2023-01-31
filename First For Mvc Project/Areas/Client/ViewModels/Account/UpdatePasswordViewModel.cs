﻿using System.ComponentModel.DataAnnotations;

namespace First_For_Mvc_Project.Areas.Client.ViewModels.Account
{
    public class UpdatePasswordViewModel
    {
        [Required]
        public string? CurrentPassword { get; set; }

        [Required]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [Compare(nameof(Password), ErrorMessage = "Password and confirm password is not same")]
        public string? ConfirmPassword { get; set; }
    }
}
