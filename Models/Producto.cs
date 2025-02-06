namespace BioShopDB.Models
{
    public class Producto
    {
        // Cambiar a int? para permitir valores NULL en la base de datos
        public int? Id { get; set; }  

        // Propiedades obligatorias, no cambiadas
        public required string Nombre { get; set; }
        public required string Descripcion { get; set; }

        // Cambiar a int? si TiendaId puede ser NULL
        public int? TiendaId { get; set; }

        // ImagenUrl puede ser NULL (opcional)
        public string? ImagenUrl { get; set; }
    }
}

