using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("Compra_seguro")]
    public class CompraSeguro
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Se requiere la Fecha de Compra")]
        public DateTime FechaCompra { get; set; }
        [Required(ErrorMessage = "Se requiere la Fecha de Vencimiento")]
        public DateTime FechaVencimiento { get; set; }
        [Required(ErrorMessage = "Se requiere el Id de la Impresora")]
        public int ImpresoraId { get; set; }
        public Impresora Impresora { get; set; }
        [Required(ErrorMessage = "Se requiere Id del Seguro")]
        public int SeguroId { get; set; }
        public Seguro Seguro { get; set; }
    }
}