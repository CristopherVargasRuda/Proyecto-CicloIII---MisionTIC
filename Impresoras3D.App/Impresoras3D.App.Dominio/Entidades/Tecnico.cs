namespace Impresoras3D.App.Dominio
{
    public class Tecnico : Persona
    {
        public string Direccion { get; set; }
        public string NivelEstudios { get; set; }
        public List<Impresora> Impresoras { get; set; }
        public List<ServicioTecnico> ServiciosTecnicos { get; set; }
    }
}