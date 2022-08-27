using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("Servicio_Tecnico")]
    public class ServicioTecnico
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public List<MantenimientoComponente> MantenimientoComponentes { get; set; }
        public List<CambioComponente> CambioComponentes { get; set; }
        public string ImpresoraPlacaInventario { get; set; }
        public Impresora Impresora { get; set; }
        public int SoftwareId { get; set; }
        public Software Software { get; set; }
        public int TecnicoDocumento { get; set; }
        public Tecnico Tecnico { get; set; }
    }
}