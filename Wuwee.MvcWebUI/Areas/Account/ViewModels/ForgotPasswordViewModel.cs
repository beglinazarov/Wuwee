using System.ComponentModel.DataAnnotations;

namespace Wuwee.MvcWebUI.Account.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
