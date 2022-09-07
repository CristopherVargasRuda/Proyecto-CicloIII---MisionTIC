using System.Runtime.InteropServices.ComTypes;
using System;
using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{
    public interface IRepositorioComponente
    {
        public Componente AddComponente(Componente Componente);
        public void DeleteComponente(int idComponente);
        public Componente getComponente(int idComponente);
        public IEnumerable<Componente> GetAllComponente();
        public Componente UpdateComponente(Componente Componente);
        public IEnumerable<Componente> getCabezarComponentes();
        public IEnumerable<Componente> getExtrusorComponentes();
        public IEnumerable<Componente> getCamaComponentes();
        public IEnumerable<Componente> getFuenteComponentes();
        public IEnumerable<Componente> getComponentesByImpresoraId(int impresoraId);
    }
}
