using Microsoft.AspNetCore.Mvc;
using BioShopDB.Data;
using BioShopDB.Models;
using System.Linq;

public class TiendasController : Controller
{
    private readonly ApplicationDbContext _context;

    public TiendasController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Acción que devuelve todas las tiendas
    public IActionResult Tiendas()
{
    var tiendas = _context.Tiendas
        .Select(t => new Tienda
        {
            Id = t.Id,
            Nombre = t.Nombre,
            Direccion = t.Direccion,
            Telefono = t.Telefono,
            Horario = t.Horario,
            Web = string.IsNullOrEmpty(t.Web) ? null : t.Web,  // Si Web es null o vacío, lo asignamos como null
        })
        .ToList();  // Obtener las tiendas de la base de datos

    return View(tiendas);  // Pasar las tiendas a la vista
}

}

