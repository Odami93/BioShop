using Microsoft.AspNetCore.Mvc;

namespace BioShopDB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();  // Esto busca la vista Index.cshtml
        }
    }
}
