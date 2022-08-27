using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{

    [Table("Socio_empresa")]
    public partial class SocioEmpresa : Persona

    {
        public List<CompraSeguro> CompraSeguros { get; set; }
    }
}