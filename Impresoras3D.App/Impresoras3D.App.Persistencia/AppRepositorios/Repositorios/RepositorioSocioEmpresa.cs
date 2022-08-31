using System;

using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{
    public class RepositorioSocioEmpresa : IRepositorioSocioEmpresa
    {
        private readonly AppContext _appContext;

        public RepositorioSocioEmpresa(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public SocioEmpresa AddSocioEmpresa(SocioEmpresa socioEmpresa)
        {
            var socioEmpresaAdicionado = this._appContext.SocioEmpresas.Add(socioEmpresa);

            this._appContext.SaveChanges();

            return socioEmpresaAdicionado.Entity;
        }

        public void DeleteSocioEmpresa(int documentoSocioEmpresa)
        {
            var socioEmpresa = this._appContext.SocioEmpresas.FirstOrDefault(s => s.Documento == documentoSocioEmpresa);

            if (socioEmpresa == null)
            {
                return;
            }

            this._appContext.SocioEmpresas.Remove(socioEmpresa);

            this._appContext.SaveChanges();
        }

        public SocioEmpresa getSocioEmpresa(int documentoSocioEmpresa)
        {
            var socioEmpresa = this._appContext.SocioEmpresas.FirstOrDefault ( s => s.Documento == documentoSocioEmpresa);

            return socioEmpresa;
        }

        public IEnumerable <SocioEmpresa> GetAllSocioEmpresa()
        {
            return this._appContext.SocioEmpresas;
        }



        public SocioEmpresa UpdateSocioEmpresa(SocioEmpresa socioEmpresa)
        {


            var socioEmpresaEncontrado = this._appContext.SocioEmpresas.FirstOrDefault( s => s.Documento == socioEmpresa.Documento);


            if( socioEmpresaEncontrado !=null)
            {
                socioEmpresaEncontrado.PrimerNombre = socioEmpresa.PrimerNombre;

                socioEmpresaEncontrado.SegundoNombre = socioEmpresa.SegundoNombre;

                socioEmpresaEncontrado.PrimerApellido = socioEmpresa.PrimerApellido;

                socioEmpresaEncontrado.SegundoApellido = socioEmpresa.SegundoApellido;

                socioEmpresaEncontrado.FechaNacimiento = socioEmpresa.FechaNacimiento;

                socioEmpresaEncontrado.telefono = socioEmpresa.telefono;

                

                this._appContext.SaveChanges();

                
            }

            return socioEmpresaEncontrado;
        }


    }
}
