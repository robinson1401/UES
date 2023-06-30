﻿using System.ComponentModel.DataAnnotations;

namespace UES.Services.Dto
{
    public class AuthenticateRequestDto
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
