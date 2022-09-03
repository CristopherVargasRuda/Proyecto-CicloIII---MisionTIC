using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresoras3D.App.Dominio
{
    [Table("Impresora")]
    public class Impresora
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string PlacaInventario { get; set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public int Modelo { get; set; }
        [Required]
        public int VelocidaImpresion { get; set; }
        [Required]
        public int VolumenImpresionX { get; set; }
        [Required]
        public int VolumenImpresionY { get; set; }
        [Required]
        public int VolumenImpresionZ { get; set; }
        [Required]
        public string PaisOrigen { get; set; }
        public List<ServicioTecnico> ServiciosTecnicos { get; set; }
        public int EstadoID { get; set; }
        public Estado Estado { get; set; }
        public List<CompraSeguro> CompraSeguros { get; set; }
        public List<ImpresoraComponente> ImpresoraComponentes { get; set; }
        public int OperarioId { get; set; }
        public Operario Operario { get; set; }
        public int TecnicoId { get; set; }
        public Tecnico Tecnico { get; set; }
        public int SoftwareId { get; set; }
        public Software Software { get; set; }
    }
}
