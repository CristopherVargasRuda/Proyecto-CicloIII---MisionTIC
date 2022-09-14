using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("Impresora")]
    public class Impresora
    {

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Se requiere la Placa de Inventario")]
        public string PlacaInventario { get; set; }
        [Required(ErrorMessage = "Se requiere el Tipo")]
        public string Tipo { get; set; }
        [Required(ErrorMessage = "Se requiere Id la Marca")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "Se requiere el Modelo")]
        public int Modelo { get; set; }
        [Required(ErrorMessage = "Se requiere la Velocidad de Impresion")]
        public int VelocidaImpresion { get; set; }
        [Required(ErrorMessage = "Se requiere la Velocidad de Impresion X")]
        public int VolumenImpresionX { get; set; }
        [Required(ErrorMessage = "Se requiere la Velocidad de Impresion Y")]
        public int VolumenImpresionY { get; set; }
        [Required(ErrorMessage = "Se requiere la Velocidad de Impresion Z")]
        public int VolumenImpresionZ { get; set; }
        [Required(ErrorMessage = "Se requiere el Pais de Origen")]
        public string PaisOrigen { get; set; }
        public List<ServicioTecnico> ServiciosTecnicos { get; set; }
        public int EstadoID { get; set; }
        public Estado Estado { get; set; }
        public List<CompraSeguro> CompraSeguros { get; set; }
        public List<ImpresoraComponente> ImpresoraComponentes { get; set; }
        public int? OperarioId { get; set; }
        public Operario Operario { get; set; }
        public int? TecnicoId { get; set; }
        public Tecnico Tecnico { get; set; }
        public int? SoftwareId { get; set; }
        public Software? Software { get; set; }
    }
}
