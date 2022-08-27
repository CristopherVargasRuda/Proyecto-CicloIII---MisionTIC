using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    public class Persona
    {
        [Key]
        public int Identificacion { get; set; }
        [Required, MaxLength(15)]
        public string PrimerNombre { get; set; }
        [Required, MaxLength(15)]
        public string SegundoNombre { get; set; }
        [Required, MaxLength(15)]
        public string PrimerApellido { get; set; }
        [Required, MaxLength(15)]
        public string SegundoApellido { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [Required, MaxLength(20)]
        public string telefono { get; set; }
    }
}