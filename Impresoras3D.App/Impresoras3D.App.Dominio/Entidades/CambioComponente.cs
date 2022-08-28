using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{

    [Table("Cambio_componente")]
    public class CambioComponente
    {
        [Required]
        public int ServicioTecnicoId { get; set; }
        [Required]
        public int ImpresoraComponenteId { get; set; }
        public ServicioTecnico ServicioTecnico { get; set; }
        public ImpresoraComponente ImpresoraComponente { get; set; }
    }
}