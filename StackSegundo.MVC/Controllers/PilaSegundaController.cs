using LogicaDeNegocio;
using Microsoft.AspNetCore.Mvc;
using StackSegundo.MVC.Models;
using System.Reflection;

namespace StackSegundo.MVC.Controllers
{
    public class PilaSegundaController : Controller
    {
        private Pila pila = new Pila(10);
        public static void RellenarPila(ModeloPila modeloStack, Pila pil)
        {
            for(int i = 0; i < modeloStack.StackArray.Length; i++)
            {
                pil.Stack[i] = modeloStack.StackArray[i];
            }
        }
        public IActionResult PilaIndex()
        {
            ModeloPila modeloStack = new ModeloPila();
            return View(modeloStack);
        }
        [HttpPost]
        public IActionResult Pop(ModeloPila modeloStack)
        {
            RellenarPila(modeloStack, pila);
            int? numero = pila.Pop();
            if (numero == null)
            {
                ViewBag.Message = "No se puede llevar a cabo la accion de pop ya que no hay elementos en la pila";
            }
            else
            {
                TempData["PopValue"] = pila.Peek(); 
                modeloStack.NumeroElementos--;
            }
            return View("PilaIndex",modeloStack);
        }
        [HttpPost]
        public IActionResult Push(int value, ModeloPila modeloStack)
        {
            ModeloPila modeloTemp = (ModeloPila)Cache["Temp"];
            RellenarPila(modeloStack, pila);
            string resultado=pila.Push(value);
            if(resultado == "numero introducido correctamente")
            {
                modeloStack.StackArray[(int)modeloStack.NumeroElementos] = value;
                modeloStack.NumeroElementos++;
            }
            else if(resultado == "Has sobrepasado el tamaño de la pila, el elemento no puede ser añadido")
            {
                ViewBag.Message="No se puede introducir el elemento ya que el tamaño de la pila esta superado";
            }
            Cache["Temp"] = modeloStack;
            return View("PilaIndex", modeloStack);
        }
        [HttpPost]
        public IActionResult Peek(ModeloPila modeloStack)
        {
            RellenarPila(modeloStack, pila);
            int? numero = pila.Peek(); 
            if (numero == null)
            {
                ViewBag.Message="No se puede mostrar el elemento ya que la pila está vacía";
            }
            else
            {
                TempData["PeekValue"] = pila.Peek(); 
            }
            return View("PilaIndex", modeloStack);
        }
        [HttpPost]
        public IActionResult Tamaño(ModeloPila modeloStack)
        {
           
            TempData["Tamaño"] = modeloStack.NumeroElementos;
            return View("PilaIndex", modeloStack);
        }
        [HttpPost]
        public IActionResult Comprobacion(ModeloPila modeloStack)
        {
            RellenarPila(modeloStack, pila);
            string mensaje = pila.Comprobacion();
            if (mensaje == "La pila no esta vacia")
            {
                TempData["Comprobacion"] = mensaje;
            }
            else
            {
                TempData["Comprobacion"] = mensaje;
            }
            return View("PilaIndex", modeloStack);
        }
    }
}
