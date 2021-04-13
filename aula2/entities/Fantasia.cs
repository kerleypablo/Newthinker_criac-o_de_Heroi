using System.ComponentModel.DataAnnotations;

namespace aula2.entities
{
    public class Fantasia
    {
        [Key]
        public int id { get; set; }
        public string Nome { get; set; }
        public string cor { get; set; }
        public bool capa { get; set; }

        public Poder poder { get; set; }

        public Fraqueza fraquesa { get; set; }
    }
}
