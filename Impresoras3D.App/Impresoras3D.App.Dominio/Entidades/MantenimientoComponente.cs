using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel.DataAnnotations;
namespace Impresoras3D.App.Dominio
{
    [Table("Mantenimiento_componente")]
    public class MantenimientoComponente
    {
        [Required(ErrorMessage = "Se requiere Id del Servicio Tecnico")]
        public int ServicioTecnicoId { get; set; }
        [Required(ErrorMessage = "Se requiere Id del Componente de Impresora")]
        public int ImpresoraComponenteId { get; set; }
        public ServicioTecnico ServicioTecnico { get; set; }
        public ImpresoraComponente ImpresoraComponente { get; set; }
    }
}