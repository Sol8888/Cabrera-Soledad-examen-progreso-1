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

        [Display(Name = "Año de Fabricación")]
        public int Anio  { get; set; }

        [Display(Name = "Precio del Producto")]
        public decimal Precio { get; set; }
    }
}
