using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("Tipo_cubrimiento")]
    public partial class TipoCubrimiento
    {
        [Required]
        public int Id { get; set; }


        [Required, MaxLength(50)]
        public string Nombre { get; set; }

        [Required, MaxLength(150)]
        public string Descripcion { get; set; }
        public List<SeguroYTipoCubrimiento> SeguroYTipoCubrimiento { get; set; }
    }
}
