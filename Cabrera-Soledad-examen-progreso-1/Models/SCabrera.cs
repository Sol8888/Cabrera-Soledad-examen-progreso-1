using System.ComponentModel.DataAnnotations;

namespace Cabrera_Soledad_examen_progreso_1.Models
{
    public class SCabrera
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Se necesita saber la edad")]
        [MaxLength(100)]
        public int Edad {  get; set; }

        [StringLength(100)]
        public String Nombre { get; set; }

        public bool SabeIngles { get; set; }

        [Range(1, 10, ErrorMessage = "Su promedio debe estar entre 1 y 10")]
        public decimal Proedio { get; set; }

        [DataType(DataType.Date)]
        public DateTime Cumpleanios { get; set; }
    }
}
