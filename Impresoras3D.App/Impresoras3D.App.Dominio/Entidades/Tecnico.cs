using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("Tecnico")]
    public class Tecnico : Persona
    {
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string NivelEstudios { get; set; }
        public List<Impresora> Impresoras { get; set; }
        public List<ServicioTecnico> ServiciosTecnicos { get; set; }
    }
}
