using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : EntityBase
    {
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Invalid user name length.")]
        [RegularExpression("[\\w]+", ErrorMessage = "Invalid user name format.")]
        public string UserName { get; set; }

        [StringLength(60, MinimumLength = 6, ErrorMessage = "Invalid password length.")]
        public string Password { get; set; }

        public bool Enabled { get; set; }

        [StringLength(254, ErrorMessage = "Invalid email length.")]
        [RegularExpression(@"[^@]+@[^\.]+\..+", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [RegularExpression(@"\(\+[0-9]{1,5}\)[0-9]{3,15}", ErrorMessage = "Invalid phone number format.")]
        public string PhoneNumber { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Invalid first name length.")]
        public string FirstName { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Invalid last name length.")]
        public string LastName { get; set; }

        public string Photo { get; set; }

        public DateTime JoinedDate { get; set; }

        public bool Blocked { get; set; }

        public bool ConfirmedRegistration { get; set; }

        public Wallet DefaultWallet { get; set; }

        public int InvitedUsers { get; set; }
    }
}
