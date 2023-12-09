using System.ComponentModel.DataAnnotations;

namespace ANDyNA_v2.Models
{
    public class Canchas
    {
        [Key]
        public int Id { get; set; }
        public int Numero { get; set; }
        public required string Descripcion { get; set; }
    }
}
