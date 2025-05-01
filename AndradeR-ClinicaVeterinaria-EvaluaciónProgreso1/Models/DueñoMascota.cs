using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AndradeR_ClinicaVeterinaria_EvaluaciónProgreso1.Models
{
    public class DueñoMascota
    {
        [Key]
        public int DueñoId { get; set; }
        
        [Required(ErrorMessage = "El Nombre es obligatorio.")]
        [MaxLength(10, ErrorMessage ="El Nombre no puede exceder los 10 caracteres.")]
        [DisplayName("Nombre del dueño de la mascota")]
        public String NombreDueño { get; set; }

        [Range(0, 10, ErrorMessage = "")]
        public float Edad { get; set; }

        public bool EsSocio { get; set; }

        [Range(0, 10, ErrorMessage = "")]
        public DateTime FechaSocio { get; set; }


    }
}
