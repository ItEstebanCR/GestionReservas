using System.ComponentModel.DataAnnotations;

namespace GestionReservas.Models
{
    public class Reserva 
    {
        [Required]
        [RegularExpression(@"^RES-\d{3}$", ErrorMessage = "El código debe tener el formato RES-###")]
        public string CodigoReserva { get; set; }

        [Required]
        [MinLength(3)]
        public string NombreProfesor { get; set; }

        [Required]
        [EmailAddress]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@campus\.edu$",
            ErrorMessage = "El correo debe pertenecer al dominio institucional @campus.edu")]
        public string Correo { get; set; }

        [Required]
        [RegularExpression(@"^(Lab-01|Lab-02|Lab-03|Lab-Redes|Lab-IA)$",
            ErrorMessage = "Seleccione un laboratorio válido.")]
        public string Laboratorio { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaReserva { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public TimeSpan HoraInicio { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public TimeSpan HoraFin { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(200)]
        public string Motivo { get; set; }
    }
}
