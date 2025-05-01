using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AndradeR_ClinicaVeterinaria_EvaluaciónProgreso1.Models
{
    public class DueñoMascota
    {
        [Key]
        public int DueñoId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        [DisplayName("Nombre completo")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El saldo es obligatorio.")]
        [Range(0, double.MaxValue, ErrorMessage = "El saldo debe ser un valor positivo.")]
        [DisplayName("Saldo pendiente")]
        public float SaldoPendiente { get; set; }

        [DisplayName("Es cliente frecuente")]
        public bool EsClienteFrecuente { get; set; }

        [DisplayName("Fecha de registro")]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }


}
