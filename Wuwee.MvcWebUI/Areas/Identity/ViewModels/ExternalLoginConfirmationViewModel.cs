using System.ComponentModel.DataAnnotations;

namespace Wuwee.MvcWebUI.Identity.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
