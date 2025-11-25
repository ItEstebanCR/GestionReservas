using GestionReserva.Data;
using GestionReservas.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionReservas.Controllers   
{
    public class ReservasController : Controller
    {
        private readonly ReservasRepositorio _repo;

        public ReservasController(ReservasRepositorio repo)
        {
            _repo = repo;
        }

        // LISTADO
        public IActionResult Index()
        {
            var lista = _repo.ObtenerTodas();
            return View(lista);
        }

        // GET -> FORMULARIO
        public IActionResult Crear()
        {
            return View();
        }

        // POST -> GUARDAR
        [HttpPost]
        public IActionResult Crear(Reserva r)
        {
            if (!ModelState.IsValid)
            {
                return View(r);
            }

            // validar código duplicado
            if (_repo.ExisteCodigo(r.CodigoReserva))
            {
                ModelState.AddModelError("CodigoReserva", "El código ya existe.");
                return View(r);
            }

            // guardar
            _repo.Agregar(r);

            // volver al listado
            return RedirectToAction("Index");
        }
    }
}
