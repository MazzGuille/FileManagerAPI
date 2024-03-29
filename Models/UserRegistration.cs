﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace FileManagerAPI.Models
{
    public class UserRegistration
    {
        public int UserId { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [JsonIgnore]
        public string UserPassword { get; set; } = string.Empty;

        [Required]
        [Compare("UserPassword")]
        [JsonIgnore]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
