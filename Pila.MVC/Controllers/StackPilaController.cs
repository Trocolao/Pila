using Microsoft.AspNetCore.Mvc;
using Pila.MVC.Models;
using LogicaDeNegocio;
namespace Stack.MVC.Controllers
{
    public class StackPilaController : Controller
    {
        
       
        public IActionResult Index()
        {
             
            Pila pila = new Pila();
            return View();
        }
    }
}
