using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("Impresora_componente")]
    public class ImpresoraComponente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ImpresoraId { get; set; }
        [Required]
        public int ComponenteId { get; set; }
        public Componente Componente { get; set; }
        [Required]
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }
        public List<MantenimientoComponente> MantenimientoComponentes { get; set; }
        public List<CambioComponente> CambioComponentes { get; set; }
    }
}