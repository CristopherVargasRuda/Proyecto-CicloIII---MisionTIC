using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("Compra_seguro")]
    public partial class CompraSeguro
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime FechaCompra { get; set; }
        [Required]
        public DateTime FechaVencimiento { get; set; }
        [Required, MaxLength(10)]
        public string ImpresoraPlacaInventario { get; set; }
        [Required]
        public int SeguroId { get; set; }
        public Seguro Seguro { get; set; }
        [Required]
        public int SocioEmpresaDocumento { get; set; }
        public SocioEmpresa SocioEmpresa { get; set; }
    }
}