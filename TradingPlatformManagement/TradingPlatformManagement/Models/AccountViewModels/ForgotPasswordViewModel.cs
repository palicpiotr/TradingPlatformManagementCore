﻿using System.ComponentModel.DataAnnotations;

namespace TradingPlatformManagement.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
