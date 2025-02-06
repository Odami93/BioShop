using System.ComponentModel.DataAnnotations;

namespace BioShop.Models
{
    public class Informacion
    {
        public int Id { get; set; }  // Este será tu identificador único
        public string? Mision { get; set; }
        public string? Beneficios { get; set; }
        public string? ComoFunciona { get; set; }
    }
}
