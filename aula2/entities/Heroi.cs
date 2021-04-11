using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.entities
{
    public class Heroi
    {
        [Key]
        public int id { get; set; }
        public String nome { get; set; }

        public Poderes poder { get; set; }

        public Fraquesa fraquesa { get; set; }


    }
}
