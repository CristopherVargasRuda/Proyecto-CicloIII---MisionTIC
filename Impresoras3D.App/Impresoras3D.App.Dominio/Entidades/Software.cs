using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("Software")]
    public class Software
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public string Licencia { get; set; } 
        [Required]       
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }
        public List<ServicioTecnico> ServiciosTecnicos { get; set; }
        public List<Impresora> Impresoras { get; set; }
    }
}