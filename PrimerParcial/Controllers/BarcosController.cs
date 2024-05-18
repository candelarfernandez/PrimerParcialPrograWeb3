using Microsoft.AspNetCore.Mvc;
using PrimerParcial.Entidades;
using PrimerParcial.Models;
using PrimerParcial.Servicios;
using System.Diagnostics;

namespace PrimerParcial.Controllers
{
    public class BarcosController : Controller
    {
        private readonly IServicioBarco _servicioBarco;

        public BarcosController(IServicioBarco servicioBarco)
        {
            _servicioBarco=servicioBarco;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(BarcoModel barco)
        {
            if (!ModelState.IsValid)
            {
                return View(barco);
            }
            var barcoMapeo = new Barco
            {
                nombre = barco.nombre,
                antiguedad = barco.antiguedad,
                tripulacionMaxima = barco.tripulacionMaxima
            };
            _servicioBarco.RegistrarBarco(barcoMapeo);
            return RedirectToAction("Listado");
        }
        [HttpGet]
        public IActionResult Listado()
        {
            var lista = _servicioBarco.ObtenerBarcos();
            var listaCalculadorModels = lista.Select(barco => new BarcoModel(barco)).ToList();
            return View(listaCalculadorModels);
        }

    }
}
