using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElTriangulitoP.Models
{
    [Table("combos")]
    public class combos
    {
        [Key]
        public int id_combo { get; set; }

        public string? nombre { get; set; }

        public decimal precio { get; set; }
    }
}