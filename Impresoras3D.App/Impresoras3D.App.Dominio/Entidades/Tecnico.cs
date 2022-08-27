using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("Tecnico")]
    public partial class Tecnico : Persona
    {
        [Required, MaxLength(50)]
        public string Direccion { get; set; }
        [Required, MaxLength(30)]
        public string NivelEstudios { get; set; }
       // public List<Impresora> Impresoras { get; set; }
        //public List<ServicioTecnico> ServiciosTecnicos { get; set; }
    }
}
