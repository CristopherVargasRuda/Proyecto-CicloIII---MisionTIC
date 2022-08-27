using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{

    [Table("Operario")]
    public partial class Operario : Persona
    {
        //public List<Impresora> Impresoras { get; set; }
    }
}