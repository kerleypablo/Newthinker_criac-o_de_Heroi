﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.entities
{
    public class Poderes
    {
        [Key]
        public int id { get; set; }
        public string poderes { get; set; }


    }
}
