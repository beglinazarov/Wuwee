using System.ComponentModel.DataAnnotations;

namespace Wuwee.MvcWebUI.Account.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
