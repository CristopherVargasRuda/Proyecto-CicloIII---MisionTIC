using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("Impresora_componente")]
    public class ImpresoraComponente
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Se requiere Id de la Impresora")]
        public int ImpresoraId { get; set; }
        [Required(ErrorMessage = "Se requiere Id del Componente")]
        public int ComponenteId { get; set; }
        public Componente Componente { get; set; }
        public Impresora Impresora { get; set; }
        public int? EstadoId { get; set; }
        public Estado Estado { get; set; }
        public List<MantenimientoComponente> MantenimientoComponentes { get; set; }
        public List<CambioComponente> CambioComponentes { get; set; }
    }
}