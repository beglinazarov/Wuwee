using System.ComponentModel.DataAnnotations;

namespace Wuwee.MvcWebUI.Account.ViewModels
{
    public class UseRecoveryCodeViewModel
    {
        [Required]
        public string Code { get; set; }

        public string ReturnUrl { get; set; }
    }
}
