using GestionReservas.Models;

namespace GestionReserva.Data
{
    public class ReservasRepositorio
    {
        // Lista en memoria
        private static List<Reserva> _reservas = new List<Reserva>();

        // Obtener todas las reservas
        public List<Reserva> ObtenerTodas()
        {
            return _reservas;
        }

        // Agregar una nueva reserva
        public void Agregar(Reserva r)
        {
            _reservas.Add(r);
        }

        // Verificar si el código existe
        public bool ExisteCodigo(string codigo)
        {
            return _reservas.Any(x => x.CodigoReserva == codigo);
        }
    }
}
 