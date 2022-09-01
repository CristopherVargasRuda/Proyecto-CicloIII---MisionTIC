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

        public void DeleteOperario(int idOperario)
        {
            var operario = this._appContext.Operarios.FirstOrDefault(o => o.Id == idOperario);

            if (operario == null)
            {
                return;
            }

            this._appContext.Operarios.Remove(operario);

            this._appContext.SaveChanges();
        }

        public Operario getOperario(int idOperario)
        {
            var operario = this._appContext.Operarios.FirstOrDefault(o => o.Id == idOperario);

            return operario;
        }

        public IEnumerable<Operario> GetAllOperario()
        {
            return this._appContext.Operarios;
        }

        public Operario UpdateOperario(Operario operario)
        {
            var operarioEncontrado = this._appContext.Operarios.FirstOrDefault(
                o => o.Id == operario.Id
            );

            if (operarioEncontrado != null)
            {
                operarioEncontrado.Documento = operario.Documento;

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
