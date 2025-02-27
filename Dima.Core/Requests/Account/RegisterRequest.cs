﻿using System.ComponentModel.DataAnnotations;

namespace Dima.Core.Requests.Account
{
    public class RegisterRequest
    {

        [Required(ErrorMessage = "Email")]
        [MaxLength(ErrorMessage = "Email inválido")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Senha inválida")]
        public string Password { get; set; } = string.Empty;
    }
}
