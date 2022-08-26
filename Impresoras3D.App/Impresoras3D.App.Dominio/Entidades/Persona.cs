using System.ComponentModel.DataAnnotations;

namespace Impresoras3D.App.Dominio
{
    public class Persona
    {
        [Key]
        public int Identificacion { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string telefono { get; set; }
    }
}