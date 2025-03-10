using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElTriangulitoP.Models
{
    [Table("platos")]
    public class Platos
    {
        [Key]
        public int id_plato { get; set; }

        public string nombre { get; set; }

        public decimal precio { get; set; }
    }
}