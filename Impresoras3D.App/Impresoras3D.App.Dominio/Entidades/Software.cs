using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("Software")]
    public class Software
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Version { get; set; }
        public string Licencia { get; set; }
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }
        public List<Impresora> Impresoras { get; set; }
        public List<ServicioTecnico> ServiciosTecnicos { get; set; }
    }
}