﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IdentityManagerMVC.Models
{
    public class VerifyAuthenticatorViewModel
    {
        [Required]
        public string Code { get; set; }

        public string ReturnUrl { get; set; }

        [Display(Name = "Remember me?..")]
        public bool RememberMe { get; set; } 
    }
}
