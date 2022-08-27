using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel.DataAnnotations;
namespace Impresoras3D.App.Dominio
{
    [Table("Mantenimiento_componente")]
    public class MantenimientoComponente
    {
        [Key]
        public int ServicioTecnicoId { get; set; }
        [Key]
        public int ImpresoraComponenteId { get; set; }
        public ServicioTecnico ServicioTecnico { get; set; }
        public ImpresoraComponente ImpresoraComponente { get; set; }
    }
}