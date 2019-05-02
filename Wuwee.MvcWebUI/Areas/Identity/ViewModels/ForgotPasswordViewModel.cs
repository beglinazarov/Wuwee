using System.ComponentModel.DataAnnotations;

namespace Wuwee.MvcWebUI.Identity.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
