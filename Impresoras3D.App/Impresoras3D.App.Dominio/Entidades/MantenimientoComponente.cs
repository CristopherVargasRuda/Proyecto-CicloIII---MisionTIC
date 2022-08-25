namespace Impresoras3D.App.Dominio
{
    public class MantenimientoComponente
    {
        public int ServicioTecnicoId { get; set; }
        public int ImpresoraComponenteId { get; set; }
        public ServicioTecnico ServicioTecnico { get; set; }
        public ImpresoraComponente ImpresoraComponente { get; set; }
    }
}