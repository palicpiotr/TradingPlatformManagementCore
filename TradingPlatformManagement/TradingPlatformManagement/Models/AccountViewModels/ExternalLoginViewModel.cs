using System.ComponentModel.DataAnnotations;

namespace TradingPlatformManagement.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
