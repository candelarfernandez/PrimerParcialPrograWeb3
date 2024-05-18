using Microsoft.AspNetCore.Mvc;
using PrimerParcial.Models;
using System.Diagnostics;

namespace PrimerParcial.Controllers
{
    public class InicioController : Controller
    {

        public InicioController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Bienvenida()
        {
            ViewBag.Message = "Bienvenido al sitio de Registro Aduanero de Barcos";
            return View();
        }

      
    }
}
