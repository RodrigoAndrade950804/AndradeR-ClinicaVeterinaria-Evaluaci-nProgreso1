using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AndradeR_ClinicaVeterinaria_EvaluaciónProgreso1.Models
{
    public class VisitaVeterinaria
    {
        [Key]
        public int VisitaId { get; set; }

        [Required(ErrorMessage = "La fecha de la visita es obligatoria.")]
        [DisplayName("Fecha de visita")]
        public DateTime FechaVisita { get; set; }

        [Required(ErrorMessage = "El motivo de la visita es obligatorio.")]
        [DisplayName("Motivo de la visita")]
        public MotivoVisita Motivo { get; set; }

        [DisplayName("Tarifa calculada")]
        public decimal TarifaCalculada
        {
            get
            {
                return Motivo switch
                {
                    MotivoVisita.Vacunacion => 30m,
                    MotivoVisita.RevisionGeneral => 20m,
                    MotivoVisita.Cirugia => 100m,
                    _ => 0m
                };
            }
        } 

        [DisplayName("Requiere medicación")]
        public bool RequiereMedicación { get; set; }
    }

    public enum MotivoVisita
    {
        Vacunacion,
        RevisionGeneral,
        Cirugia
    }
}

