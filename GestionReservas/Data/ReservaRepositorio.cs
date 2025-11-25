using GestionReservas.Models;

namespace GestionReservas.Data
{
    public class ReservaRepositorio
    {
        private List<Reserva> _listaReserva = new List<Reserva>();

        public List<Reserva> ObtenerTodas()
        {
            return _listaReserva;
        }

        public string Agregar(Reserva reserva)
        {
            if (_listaReserva.Any(r => r.CodigoReserva == reserva.CodigoReserva))
                return "El código de reserva ya existe.";

            if (reserva.HoraFin <= reserva.HoraInicio)
                return "La hora de fin debe ser mayor a la hora de inicio.";

            if (reserva.FechaReserva < DateTime.Today)
                return "La fecha no puede ser en el pasado.";

            _listaReserva.Add(reserva);

            return "OK";
        }
    }
}
 