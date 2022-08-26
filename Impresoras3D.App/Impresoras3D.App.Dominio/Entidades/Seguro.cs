//Se debe importar esto para especificar para usar Anotaciones de Atributos!
using System.ComponentModel.DataAnnotations;

//Se debe importar esto para anotaciones de la tabla!
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("Seguro")]
    public partial class Seguro
    {
        [Key]
        public int Identificacion { get; set; }

        //public List<CompraSeguro> CompraSeguros { get; set; }
        public List<SeguroYTipoCubrimiento> SegurosYTipoCubrimiento { get; set; }
    }
}
