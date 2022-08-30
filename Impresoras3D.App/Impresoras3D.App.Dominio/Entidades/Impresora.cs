using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("Impresora")]
    public class Impresora
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string PlacaInventario { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public int Modelo { get; set; }
        public int VelocidaImpresion { get; set; }
        public int VolumenImpresionX { get; set; }
        public int VolumenImpresionY { get; set; }
        public int VolumenImpresionZ { get; set; }
        public string PaisOrigen { get; set; }
        public List<ServicioTecnico> ServiciosTecnicos { get; set; }
        public int EstadoID { get; set; }
        public Estado Estado { get; set; }
        public List<CompraSeguro> CompraSeguros { get; set; }
        public int OperarioDocumento { get; set; }
        public Operario Operario { get; set; }
        public int TecnicoDocumento { get; set; }
        public Tecnico Tecnico { get; set; }
        public int SoftwareId { get; set; }
        public Software Software { get; set; }
    }
}
