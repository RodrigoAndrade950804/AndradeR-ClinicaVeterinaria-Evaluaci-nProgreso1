using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AndradeR_ClinicaVeterinaria_EvaluaciónProgreso1.Models;

    public class AndradeR_SQL : DbContext
    {
        public AndradeR_SQL (DbContextOptions<AndradeR_SQL> options)
            : base(options)
        {
        }

        public DbSet<AndradeR_ClinicaVeterinaria_EvaluaciónProgreso1.Models.VisitaVeterinaria> VisitaVeterinaria { get; set; } = default!;

public DbSet<AndradeR_ClinicaVeterinaria_EvaluaciónProgreso1.Models.Mascota> Mascota { get; set; } = default!;

public DbSet<AndradeR_ClinicaVeterinaria_EvaluaciónProgreso1.Models.DueñoMascota> DueñoMascota { get; set; } = default!;
    }
