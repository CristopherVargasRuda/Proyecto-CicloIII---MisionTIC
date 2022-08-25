namespace Impresoras3D.App.Dominio
{
    public class SeguroYTipoSeguro
    {
        public int SeguroId { get; set; }
        public int TipoSeguroId { get; set; }
        public Seguro Seguro { get; set; }
        public TipoSeguro TipoSeguro { get; set; }
    }
}