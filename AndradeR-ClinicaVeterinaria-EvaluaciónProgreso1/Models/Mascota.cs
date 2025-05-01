using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AndradeR_ClinicaVeterinaria_EvaluaciónProgreso1.Models
{
    public class Mascota
    {
        [Key]
        public int MascotaId { get; set; }

        [Required(ErrorMessage = "El nombre de la mascota es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        [DisplayName("Nombre de la mascota")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La especie es obligatoria.")]
        [MaxLength(50, ErrorMessage = "La especie no puede exceder los 50 caracteres.")]
        [DisplayName("Especie")]
        public string Especie { get; set; }

        [Required(ErrorMessage = "La edad es obligatoria.")]
        [Range(0, 100, ErrorMessage = "La edad debe estar entre 0 y 100 años.")]
        [DisplayName("Edad")]
        public int Edad { get; set; }

        [DisplayName("Peso (kg)")]
        [Range(0.1, 200, ErrorMessage = "El peso debe ser un valor positivo.")]
        public float Peso { get; set; }

        [Required(ErrorMessage = "El dueño es obligatorio.")]
        [DisplayName("Dueño")]
        public int DueñoId { get; set; }
    }
}
