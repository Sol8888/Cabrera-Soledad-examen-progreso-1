using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cabrera_Soledad_examen_progreso_1.Models
{
    public class SCabrera
    {
        [Key]
        [Required]
        [Display(Name = "Celular")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Se necesita saber la edad")]
        public int Edad {  get; set; }

        [StringLength(100)]
        public String Nombre { get; set; }

        [Display(Name = "Sabe Inglés")]
        public bool SabeIngles { get; set; }

        [Range(1, 10, ErrorMessage = "Su promedio debe estar entre 1 y 10")]
        public decimal Promedio { get; set; }

        [Display(Name = "Cumpleaños")]
        [DataType(DataType.Date)]
        public DateTime Cumpleanios { get; set; }

        public Celular? Celular { get; set; }

        [ForeignKey("Celular")]
        public int IdCelular { get; set; }
    }
}
