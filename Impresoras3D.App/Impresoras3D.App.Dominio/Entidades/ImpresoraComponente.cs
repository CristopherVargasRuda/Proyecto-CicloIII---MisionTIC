using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("Impresora_componente")]
    public class ImpresoraComponente
    {

        public int Id { get; set; }
        public string ImpresoraPlacaInventario { get; set; }
        public int ComponenteId { get; set; }
        public Componente Componente { get; set; }
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }
        public List<MantenimientoComponente> MantenimientoComponentes { get; set; }
        public List<CambioComponente> CambioComponentes { get; set; }
    }
}