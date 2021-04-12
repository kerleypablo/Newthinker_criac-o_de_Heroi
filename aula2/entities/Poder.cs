using System.ComponentModel.DataAnnotations;

namespace aula2.entities
{
    public class Poder
    {
        [Key]
        public int id { get; set; }
        public string poder { get; set; }
    }
}
