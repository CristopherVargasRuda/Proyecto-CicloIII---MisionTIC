using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("SeguroyTipoCubrimiento")]
    public partial class SeguroYTipoCubrimiento
    {
        public int SeguroId { get; set; }
        public int TipoCubrimientoId { get; set; }
        public Seguro Seguro { get; set; }
        public TipoCubrimiento TipoCubrimiento { get; set; }
    }
}
