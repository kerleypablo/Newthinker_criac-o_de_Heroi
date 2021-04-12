using aula2.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.DTO.Heroi.AdicionarHeroi
{
    public class AdicionarHeroiRequest
    {

        public String nome { get; set; }

        public Poderes poder { get; set; }

        public Fraquesa fraquesa { get; set; }



    }
}
