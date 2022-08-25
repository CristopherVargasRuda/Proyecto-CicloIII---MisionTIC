namespace Impresoras3D.App.Dominio
{
    public class CompraSeguro
    {
        public int Id { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string ImpresoraPlacaInventario { get; set; }
        public int SeguroId { get; set; }
        public Seguro Seguro { get; set; }
        public int SocioEmpresaDocumento { get; set; }
        public SocioEmpresa SocioEmpresa { get; set; }
    }
}