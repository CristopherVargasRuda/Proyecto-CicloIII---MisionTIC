using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("Compra_seguro")]
    public class CompraSeguro
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime FechaCompra { get; set; }
        [Required]
        public DateTime FechaVencimiento { get; set; }
        [Required]
        public string ImpresoraId { get; set; }
        public Impresora Impresora { get; set; }
        [Required]
        public int SeguroId { get; set; }
        public Seguro Seguro { get; set; }
    }
}