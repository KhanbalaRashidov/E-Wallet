using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PaymentInstrument:EntityBase
    {
        [ForeignKey("Owner")]
        public int OwnerId { get;set; }
        public User Owner { get; set; }

        public int InstrumentType { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Invalid  name length.")]
        public string Name { get; set; }

    }
}
