using System;

using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{
    public class RepositorioOperario : IRepositorioOperario
    {
        private readonly AppContext _appContext;

        public RepositorioOperario(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public Operario AddOperario(Operario operario)
        {
            var operarioAdicionado = this._appContext.Operarios.Add(operario);

            this._appContext.SaveChanges();

            return operarioAdicionado.Entity;
        }

        public void DeleteOperario(int documentoOperario)
        {
            var operario = this._appContext.Operarios.FirstOrDefault(
                o => o.Documento == documentoOperario
            );

            if (operario == null)
            {
                return;
            }

            this._appContext.Operarios.Remove(operario);

            this._appContext.SaveChanges();
        }

        public Operario getOperario(int documentoOperario)
        {
            var operario = this._appContext.Operarios.FirstOrDefault(
                o => o.Documento == documentoOperario
            );

            return operario;
        }

        public IEnumerable<Operario> GetAllOperario()
        {
            return this._appContext.Operarios;
        }

        public Operario UpdateOperario(Operario operario)
        {
            var operarioEncontrado = this._appContext.Operarios.FirstOrDefault(
                o => o.Documento == operario.Documento
            );

            if (operarioEncontrado != null)
            {
                operarioEncontrado.PrimerNombre = operario.PrimerNombre;

                operarioEncontrado.SegundoNombre = operario.SegundoNombre;

                operarioEncontrado.PrimerApellido = operario.PrimerApellido;

                operarioEncontrado.SegundoApellido = operario.SegundoApellido;

                operarioEncontrado.FechaNacimiento = operario.FechaNacimiento;

                operarioEncontrado.telefono = operario.telefono;

                operarioEncontrado.Impresoras = operario.Impresoras;

                this._appContext.SaveChanges();
            }

            return operarioEncontrado;
        }
    }
}
