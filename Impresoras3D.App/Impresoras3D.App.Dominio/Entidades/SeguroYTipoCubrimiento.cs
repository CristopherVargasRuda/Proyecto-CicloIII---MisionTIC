using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("Seguro_tipoCubrimiento")]
    public class SeguroYTipoCubrimiento
    {
        [Required]
        public int SeguroId { get; set; }
        [Required]
        public int TipoCubrimientoId { get; set; }
        public Seguro Seguro { get; set; }
        public TipoCubrimiento TipoCubrimiento { get; set; }
    }
}
