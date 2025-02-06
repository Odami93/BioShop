using Microsoft.AspNetCore.Mvc;
using BioShop.Models;

namespace BioShop.Controllers
{
    public class InformacionController : Controller
    {
        // Acción para la vista de Información
        public IActionResult Informacion()
        {
            var modeloInformacion = new Informacion
            {
                Mision = "BioShop es una plataforma que promueve productos sostenibles.",
                Beneficios = "Consumo responsable, productos ecológicos y locales.",
                ComoFunciona = "BioShop conecta usuarios con tiendas responsables."
            };

            return View(modeloInformacion); // Pasa el modelo a la vista
        }
    }
}





