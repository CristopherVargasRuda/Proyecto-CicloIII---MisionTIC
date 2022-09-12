using System;
using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{

    public interface IRepositorioJefeOperaciones
    {
        public JefeOperaciones AddJefeOperaciones(JefeOperaciones JefeOperaciones);
        public void DeleteJefeOperaciones(int idJefeOperaciones);
        public JefeOperaciones getJefeOperaciones(int idJefeOperaciones);
        public IEnumerable<JefeOperaciones> GetAllJefeOperaciones();
        public JefeOperaciones UpdateJefeOperaciones(JefeOperaciones JefeOperaciones);
        public JefeOperaciones getByDocument(int document);
        public JefeOperaciones getByLogin(int document, string pass);
    }
}