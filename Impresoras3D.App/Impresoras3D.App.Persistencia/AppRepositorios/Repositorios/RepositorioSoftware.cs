using System;

using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{
    public class RepositorioSoftware : IRepositorioSoftware
    {
        private readonly AppContext _appContext;

        public RepositorioSoftware(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public Software AddSoftware(Software software)
        {
            var softwareAdicionado = this._appContext.Softwares.Add(software);

            this._appContext.SaveChanges();

            return softwareAdicionado.Entity;
        }

        public void DeleteSoftware(int idSoftware)
        {
            var software = this._appContext.Softwares.FirstOrDefault(s => s.Id == idSoftware);

            if (software == null)
            {
                return;
            }

            this._appContext.Softwares.Remove(software);

            this._appContext.SaveChanges();
        }

        public Software getSoftware(int idSoftware)
        {
            var software = this._appContext.Softwares.FirstOrDefault(s => s.Id == idSoftware);

            return software;
        }

        public IEnumerable<Software> GetAllSoftware()
        {
            return this._appContext.Softwares;
        }

        public Software UpdateSoftware(Software software)
        {
            var softwareEncontrado = this._appContext.Softwares.FirstOrDefault(
                s => s.Id == software.Id
            );

            if (softwareEncontrado != null)
            {
                softwareEncontrado.Nombre = software.Nombre;

                softwareEncontrado.Version = software.Version;

                softwareEncontrado.Licencia = software.Licencia;

                softwareEncontrado.EstadoId = software.EstadoId;

                softwareEncontrado.Estado = software.Estado;

                softwareEncontrado.ServiciosTecnicos = software.ServiciosTecnicos;

                softwareEncontrado.Impresoras = software.Impresoras;

                this._appContext.SaveChanges();
            }

            return softwareEncontrado;
        }
    }
}
