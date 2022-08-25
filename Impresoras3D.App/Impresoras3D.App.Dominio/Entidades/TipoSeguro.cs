namespace Impresoras3D.App.Dominio
{
    public class TipoSeguro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<SeguroYTipoSeguro> SeguroYTipoSeguros  { get; set; }
    }
}