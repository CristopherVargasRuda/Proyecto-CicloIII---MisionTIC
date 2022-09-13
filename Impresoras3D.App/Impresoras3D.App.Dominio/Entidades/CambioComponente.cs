using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{

    [Table("Cambio_componente")]
    public class CambioComponente
    {
        [Required(ErrorMessage = "Se requiere Id del Servicio Tecnico")]
        public int ServicioTecnicoId { get; set; }
        [Required(ErrorMessage = "Se requiere Id de Impresora Componente")]
        public int ImpresoraComponenteId { get; set; }
        public ServicioTecnico ServicioTecnico { get; set; }
        public ImpresoraComponente ImpresoraComponente { get; set; }
    }
}