using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AndradeR_ClinicaVeterinaria_EvaluaciónProgreso1.Models
{
    public class Mascota
    {
        [Key]
        public int MascotaId { get; set; }

        [Required(ErrorMessage = "El Nombre de la mascota es obligatorio.")]
        [MaxLength(10, ErrorMessage = "El Nombre de la mascota no puede exceder los 10 caracteres.")]
        [DisplayName("Nombre de la mascota")]
        public String NombreMascota { get; set; }

        [Range(0, 20, ErrorMessage = "La raza de la mascota no puede exceder los 20 caracteres.")]
        [DisplayName("Nombre de la mascota")]
        public String Raza { get; set; }

        public bool Vacunada { get; set; }

        public String TipoMedicación { get; set; }
    }
}
