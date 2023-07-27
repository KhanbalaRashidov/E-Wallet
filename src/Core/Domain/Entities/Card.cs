using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Card : EntityBase
    {
        public string Name { get; set; }

        [RegularExpression("([\\d]{4}-){3}[\\d]{4}", ErrorMessage = "Invalid card number")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "Cardholder name cannot be empty")]
        [RegularExpression("[A-Za-z ]{2,40}", ErrorMessage = "Invalid cardholder name")]
        public string CardholderName { get; set; }

        [Required(ErrorMessage = "Expiration date cannot be empty")]
        [RegularExpression("(0[1-9]|1[0-2])/[0-9]{2}", ErrorMessage = "Invalid expiration date")]
        public string ExpirationDate { get; set; }

        [Required(ErrorMessage = "CSV cannot be empty")]
        [RegularExpression("[\\d]{3}", ErrorMessage = "Invalid CSV format")]
        public string Csv { get; set; }

        public bool Deleted { get; set; }

    }
}
