﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.entities
{
    public class Fraqueza
    {
        [Key]
        public int id { get; set; }

        public string nome { get; set; }

    }
}
