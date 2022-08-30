using System;

using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{
    
    public interface IRepositorioJefeOperaciones
    {
        public JefeOperaciones AddJefeOperaciones(JefeOperaciones JefeOperaciones);

        public void DeleteJefeOperaciones (int documentoJefeOperaciones);

        public JefeOperaciones getJefeOperaciones (int documentoJefeOperaciones);

        public IEnumerable <JefeOperaciones> GetAllJefeOperaciones();

        public JefeOperaciones UpdateJefeOperaciones(JefeOperaciones JefeOperaciones);
    }


}