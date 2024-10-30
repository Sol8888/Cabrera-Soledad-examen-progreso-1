using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cabrera_Soledad_examen_progreso_1.Models;

namespace Cabrera_Soledad_examen_progreso_1.Data
{
    public class Cabrera_Soledad_examen_progreso_1Context : DbContext
    {
        public Cabrera_Soledad_examen_progreso_1Context (DbContextOptions<Cabrera_Soledad_examen_progreso_1Context> options)
            : base(options)
        {
        }

        public DbSet<Cabrera_Soledad_examen_progreso_1.Models.Celular> Celular { get; set; } = default!;
        public DbSet<Cabrera_Soledad_examen_progreso_1.Models.SCabrera> SCabrera { get; set; } = default!;
    }
}
