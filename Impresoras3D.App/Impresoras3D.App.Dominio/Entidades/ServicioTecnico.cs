using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("Servicio_Tecnico")]
    public class ServicioTecnico
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Se requiere la fecha")]
        public DateTime Fecha { get; set; }
        public List<MantenimientoComponente> MantenimientoComponentes { get; set; }
        public List<CambioComponente> CambioComponentes { get; set; }
        [Required(ErrorMessage = "Se requiere Id de la Impresora")]
        public int ImpresoraId { get; set; }
        public Impresora Impresora { get; set; }
        public int? SoftwareId { get; set; }
        public Software? Software { get; set; }
        [Required(ErrorMessage = "Se requiere Id del Tecnico")]
        public int TecnicoId { get; set; }
        public Tecnico Tecnico { get; set; }
    }
}