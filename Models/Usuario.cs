namespace BioShopDB.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        // Propiedades obligatorias
        public required string Nombre { get; set; }
        public required string Correo { get; set; }
        public required string Teléfono { get; set; }
        public required string Dirección { get; set; }

        // Relación con las evaluaciones (un usuario puede tener muchas evaluaciones)
        
    }
}
