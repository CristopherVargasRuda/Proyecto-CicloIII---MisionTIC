using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("Seguro_tipoCubrimiento")]
    public partial class SeguroYTipoCubrimiento
    {
        [Required]
        public int SeguroId { get; set; }
        [Required]
        public int TipoCubrimientoId { get; set; }
        [Required]
        public Seguro Seguro { get; set; }
        [Required]
        public TipoCubrimiento TipoCubrimiento { get; set; }
    }
}
