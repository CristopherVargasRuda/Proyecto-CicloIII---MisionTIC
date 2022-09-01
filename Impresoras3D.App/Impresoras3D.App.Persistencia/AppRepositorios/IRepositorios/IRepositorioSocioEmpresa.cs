using System;

using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{

    public interface IRepositorioSocioEmpresa
    {

        public SocioEmpresa AddSocioEmpresa(SocioEmpresa SocioEmpresa);

        public void DeleteSocioEmpresa (int idSocioEmpresa);

        public SocioEmpresa getSocioEmpresa (int idSocioEmpresa);

        public IEnumerable <SocioEmpresa> GetAllSocioEmpresa();

        public SocioEmpresa UpdateSocioEmpresa(SocioEmpresa SocioEmpresa);

    }


}