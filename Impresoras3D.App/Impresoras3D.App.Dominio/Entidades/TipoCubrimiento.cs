using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("Tipo_cubrimiento")]
    public class TipoCubrimiento
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Se requiere el Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Se requiere la Descripcion")]
        public string Descripcion { get; set; }
        
        public List<SeguroYTipoCubrimiento> SeguroYTipoCubrimiento { get; set; }
    }
}
