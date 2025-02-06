using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BioShopDB.Models;
using BioShopDB.Data;

namespace BioShop.Controllers
{
    public class ProductosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Productos
        public async Task<IActionResult> Productos()
        {
            // Obtener todos los productos desde la base de datos
            var productos = await _context.Productos.ToListAsync();
            if (productos == null || productos.Count == 0)
            {
                // Mostrar mensaje si no hay productos
                ViewBag.Mensaje = "No hay productos disponibles.";
            }
            return View(productos);
        }

        // GET: Productos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Productos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Descripcion,Precio,ImagenUrl,TiendaId")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                // Agregar el nuevo producto a la base de datos
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Productos)); // Redirige a la lista de productos
            }
            return View(producto);
        }

        // GET: Productos/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var producto = await _context.Productos.FirstOrDefaultAsync(m => m.Id == id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }

            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Productos)); // Redirige a la lista de productos
        }
    }
}
