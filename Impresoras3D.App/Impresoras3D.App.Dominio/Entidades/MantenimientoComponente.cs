using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel.DataAnnotations;
namespace Impresoras3D.App.Dominio
{
    [Table("Mantenimiento_componente")]
    public class MantenimientoComponente
    {
        [Required]
        public int ServicioTecnicoId { get; set; }
        [Required]
        public int ImpresoraComponenteId { get; set; }
        public ServicioTecnico ServicioTecnico { get; set; }
        public ImpresoraComponente ImpresoraComponente { get; set; }
    }
}