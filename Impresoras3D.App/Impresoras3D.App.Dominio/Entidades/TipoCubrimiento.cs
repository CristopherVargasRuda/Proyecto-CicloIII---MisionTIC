using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("TipoCubrimiento")]
    public partial class TipoCubrimiento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<SeguroYTipoCubrimiento> SeguroYTipoCubrimiento { get; set; }
    }
}
