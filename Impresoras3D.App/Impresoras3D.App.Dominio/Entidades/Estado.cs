using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{

    [Table("Estado")]
    public class Estado
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
    }
} 