using GestionReservas.Data;
using GestionReservas.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionReservas.Controllers
{    
    public class ReservaController : Controller
    {
        private readonly ReservaRepositorio _repo;

        public ReservaController(ReservaRepositorio repo)
        {
            _repo = repo;
        }

        // LISTADO
        public IActionResult Index()
        {
            var datos = _repo.ObtenerTodas();
            return View(datos);
        }

        // FORMULARIO
        public IActionResult Crear()
        {
            return View();
        }

        // GUARDAR
        [HttpPost]
        public IActionResult Crear(Reserva reserva)
        {
            if (!ModelState.IsValid)
                return View(reserva);

            var resultado = _repo.Agregar(reserva);

            if (resultado != "OK")
            {
                ModelState.AddModelError(string.Empty, resultado);
                return View(reserva);
            }

            return RedirectToAction("Index");
        }
    }
}
