using System.ComponentModel.DataAnnotations;

namespace aula2.entities
{
    public class Heroi
    {
        [Key]
        public int id { get; set; }

        public string nome { get; set; }

        public Poder poder { get; set; }

        public Fraquesa fraquesa { get; set; }
    }
}
