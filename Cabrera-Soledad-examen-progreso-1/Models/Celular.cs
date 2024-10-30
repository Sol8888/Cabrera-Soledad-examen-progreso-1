using System.ComponentModel.DataAnnotations;

namespace Cabrera_Soledad_examen_progreso_1.Models
{
    public class Celular
    {
        [Key]
        [Required]
        public int Id { get; set; }
        
        [StringLength(100)]
        public string Modelo { get; set; }
        
        [MaxLength(10000)]
        public int año  { get; set; }

        [Range(1, 5000, ErrorMessage = "El precio debe ser entre $1 y $5000")]
        public decimal precio { get; set; }
    }
}
