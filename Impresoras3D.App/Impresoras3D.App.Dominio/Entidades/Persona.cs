using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{

    public class Persona
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese el Documento")]   
        public int Documento { get; set; }
        [Required(ErrorMessage = "Ingrese el Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Ingrese Primer Nombre")]
        public string PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        [Required(ErrorMessage = "Ingrese Primer Apellido")]
        public string PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        [Required(ErrorMessage = "Ingrese la Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        [Required(ErrorMessage = "Ingrese el Numero de telefono")]
        public string telefono { get; set; }
    }
}
