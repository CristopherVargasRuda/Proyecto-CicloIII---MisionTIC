using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("Tecnico")]
    public class Tecnico : Persona
    {
        [Required(ErrorMessage = "Se requiere la Direccion")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Se requiere Nivel de Estudio")]
        public string NivelEstudios { get; set; }
        public List<Impresora> Impresoras { get; set; }
        public List<ServicioTecnico> ServiciosTecnicos { get; set; }
    }
}
