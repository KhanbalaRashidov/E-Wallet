using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Category:EntityBase
    {
        [StringLength(50, MinimumLength = 4)]
        public string Name { get; set; }

        public int CreatorId { get; set; }

        [ForeignKey("CreatorId")]
        public User Creator { get; set; }
    }
}
