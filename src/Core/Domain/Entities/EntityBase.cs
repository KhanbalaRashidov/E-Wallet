﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EntityBase
    {
        public int Id { get; set; } = default!;

        public override string ToString()
        {
            return $"{GetType().Name}[Id={Id}]";
        }
    }
}
