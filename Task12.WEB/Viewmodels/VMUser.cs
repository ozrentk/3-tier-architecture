﻿using System.ComponentModel;

namespace Task12.WEB.Viewmodels
{
    public class VMUser
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        [DisplayName("User name")]
        public string Username { get; set; } = null!;

        [DisplayName("First name")]
        public string FirstName { get; set; } = null!;

        [DisplayName("Last name")]
        public string LastName { get; set; } = null!;

        [DisplayName("E-mail")]
        public string Email { get; set; } = null!;

        public string PwdHash { get; set; } = null!;

        public string PwdSalt { get; set; } = null!;

        public bool IsConfirmed { get; set; }

        public string? SecurityToken { get; set; }
    }
}
