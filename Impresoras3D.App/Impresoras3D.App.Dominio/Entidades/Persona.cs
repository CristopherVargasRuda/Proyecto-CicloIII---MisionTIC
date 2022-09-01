using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{

    public class Persona
    {
        [Key]
        public int Id { get; set; }

        [Required]
        
        public int Documento { get; set; }

        [Required]
        public string PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }

        [Required]
        public string PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        public string telefono { get; set; }
    }
}
