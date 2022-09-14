using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("Software")]
    public class Software
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Se requiere el Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Se requiere la Version")]
        public string Version { get; set; }
        [Required(ErrorMessage = "Se requiere la Licencia")]
        public string Licencia { get; set; }      
        public int? EstadoId { get; set; }
        public Estado Estado { get; set; }
        public List<ServicioTecnico> ServiciosTecnicos { get; set; }
        public List<Impresora> Impresoras { get; set; }
    }
}