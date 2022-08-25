namespace Impresoras3D.App.Dominio
{
    public class Seguro
    {
        public int Id { get; set; }
        public List<CompraSeguro> CompraSeguros { get; set; }
        public List<SeguroYTipoSeguro> SegurosYTipoSeguros { get; set; }
    }
}