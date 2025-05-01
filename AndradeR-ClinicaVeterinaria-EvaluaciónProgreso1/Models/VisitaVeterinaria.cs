using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AndradeR_ClinicaVeterinaria_EvaluaciónProgreso1.Models
{
    public class VisitaVeterinaria
    {
        public int VisitaId { get; set; }

        [Required(ErrorMessage = "El motivo de la visita es obligatorio.")]
        [MaxLength(200, ErrorMessage = "El motivo de la visita no puede exceder los 200 caracteres.")]
        [DisplayName("Motivo de la visita")]
        public String MotivoVisita { get; set; }
        
        public bool RequiereMedicación { get; set; }
    }
}
