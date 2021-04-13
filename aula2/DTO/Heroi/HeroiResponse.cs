using aula2.DTO.Fraquesa;
using aula2.DTO.Poder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.DTO.Heroi
{
    public class HeroiResponse
    {
        public int id { get; set; }

        public string nome { get; set; }

        public int poderid { get; set; }

        public int fraquesaid { get; set; }

        public FraquezaResponse fraquesa { get; set; }
        public PoderResponse poder { get; set; }
    }
}
