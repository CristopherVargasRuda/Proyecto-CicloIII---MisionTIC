using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("Seguro_tipoCubrimiento")]
    public class SeguroYTipoCubrimiento
    {
        [Required(ErrorMessage = "Se requiere Id del Seguro")]
        public int SeguroId { get; set; }
        [Required(ErrorMessage = "Se requiere el Tipo de Cubrimiento")]
        public int TipoCubrimientoId { get; set; }
        public Seguro Seguro { get; set; }
        public TipoCubrimiento TipoCubrimiento { get; set; }
    }
}
