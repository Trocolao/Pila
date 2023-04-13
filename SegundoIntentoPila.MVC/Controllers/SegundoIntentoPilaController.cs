using Microsoft.AspNetCore.Mvc;

namespace SegundoIntentoPila.MVC.Controllers
{
    public class SegundoIntentoPilaController : Controller
    {
        public IActionResult SegundoIntentoIndex()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Push()
        {

            return View();
        }
    }
}
