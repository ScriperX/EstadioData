using System.ComponentModel.DataAnnotations;

namespace EstadioData.Data.Entities
{
    public class Team
    {
        public int Id { get; set; }

        [Display(Name = "Equipo")]
        [MaxLength(90, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = " El campo {0} es obligatorio.")]
        public string Name { get; set; }
    }
}
