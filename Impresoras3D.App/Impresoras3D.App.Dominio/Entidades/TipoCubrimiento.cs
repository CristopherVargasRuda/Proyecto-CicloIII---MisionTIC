using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("Tipo_cubrimiento")]
    public class TipoCubrimiento
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Descripcion { get; set; }
        
        public List<SeguroYTipoCubrimiento> SeguroYTipoCubrimiento { get; set; }
    }
}
