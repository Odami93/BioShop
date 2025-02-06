namespace BioShopDB.Models
{
    public class Tienda
    {
        public int Id { get; set; }

        // Propiedades obligatorias
        public string Nombre { get; set; } = string.Empty; // Inicialización con valor predeterminado
        public string Direccion { get; set; } = string.Empty; // Inicialización con valor predeterminado
        public string? Telefono { get; set; } // Valor opcional
        public string Horario { get; set; } = string.Empty; // Inicialización con valor predeterminado
        public string? Web { get; set; } // Valor opcional


        // Relación con los productos (una tienda puede tener muchos productos)
        public ICollection<Producto> Productos { get; set; } = new List<Producto>();

        // Constructor para inicializar la propiedad Nombre
        public Tienda()
        {
            Nombre = string.Empty;
        }
    }
}
