using System.ComponentModel.DataAnnotations;
namespace Impresoras3D.App.Dominio
{
    public class CambioComponente
    {
        [Key]
        public int ServicioTecnicoId { get; set; }
        [Key]
        public int ImpresoraComponenteId { get; set; }
        public ServicioTecnico ServicioTecnico { get; set; }
        public ImpresoraComponente ImpresoraComponente { get; set; }
    }
}