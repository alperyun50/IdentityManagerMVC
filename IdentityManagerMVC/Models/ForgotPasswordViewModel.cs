using System.ComponentModel.DataAnnotations;

namespace IdentityManagerMVC.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
