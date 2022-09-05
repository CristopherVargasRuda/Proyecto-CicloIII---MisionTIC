using System;

using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{
    public interface IRepositorioEstado
    {
        public Estado AddEstado(Estado Estado);
        public void DeleteEstado(int idEstado);
        public Estado getEstado(int idEstado);
        public IEnumerable<Estado> GetAllEstado();
        public Estado UpdateEstado(Estado Estado);
        public IEnumerable<Estado> GetImpresoraEstados();
        public IEnumerable<Estado> GetSoftwareEstados();
        public IEnumerable<Estado> GetComponenteEstados();
    }
}
