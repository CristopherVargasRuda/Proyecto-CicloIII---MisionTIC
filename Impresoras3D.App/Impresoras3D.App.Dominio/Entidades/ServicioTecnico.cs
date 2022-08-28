using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("Servicio_Tecnico")]
    public class ServicioTecnico
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        public List<MantenimientoComponente> MantenimientoComponentes { get; set; }
        public List<CambioComponente> CambioComponentes { get; set; }
        [Required]
        public string ImpresoraPlacaInventario { get; set; }
        public Impresora Impresora { get; set; }
        [Required]
        public int SoftwareId { get; set; }
        public Software Software { get; set; }
        [Required]
        public int TecnicoDocumento { get; set; }
        public Tecnico Tecnico { get; set; }
    }
}