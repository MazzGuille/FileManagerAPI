﻿using System.ComponentModel.DataAnnotations;

namespace FileManagerAPI.Models
{
    public class UserLogin
    {
        public int UserId { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string UserPassword { get; set; } = string.Empty;

    }
}
