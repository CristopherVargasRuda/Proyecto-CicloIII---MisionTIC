using System;
using Impresoras3D.App.Dominio;

namespace Impresoras3D.App.Persistencia
{
    public class RepositorioTipoCubrimiento : IRepositorioTipoCubrimiento
    {
        private readonly AppContext _appContext;
        public RepositorioTipoCubrimiento(AppContext appContext)
        {
            this._appContext = appContext;
        }
        public TipoCubrimiento AddTipoCubrimiento(TipoCubrimiento tipoCubrimiento)
        {
            var tipoCubrimientoAdicionado = this._appContext.TipoCubrimientos.Add(tipoCubrimiento);
            this._appContext.SaveChanges();
            return tipoCubrimientoAdicionado.Entity;
        }


        public void DeleteTipoCubrimiento(int idTipoCubrimiento)
        {
            var tipoCubrimiento = this._appContext.TipoCubrimientos.FirstOrDefault(
                t => t.Id == idTipoCubrimiento
            );
            if (tipoCubrimiento == null)
            {
                return;
            }
            this._appContext.TipoCubrimientos.Remove(tipoCubrimiento);
            this._appContext.SaveChanges();
        }

        public TipoCubrimiento getTipoCubrimiento(int idTipoCubrimiento)
        {
            var tipoCubrimiento = this._appContext.TipoCubrimientos.FirstOrDefault(
                t => t.Id == idTipoCubrimiento
            );
            return tipoCubrimiento;
        }

        public IEnumerable<TipoCubrimiento> GetAllTipoCubrimiento()
        {
            return this._appContext.TipoCubrimientos;
        }

        public TipoCubrimiento UpdateTipoCubrimiento(TipoCubrimiento tipoCubrimiento)
        {
            var tipoCubrimientoEncontrado = this._appContext.TipoCubrimientos.FirstOrDefault(
                t => t.Id == tipoCubrimiento.Id
            );

            if (tipoCubrimientoEncontrado != null)
            {
                tipoCubrimientoEncontrado.Nombre = tipoCubrimiento.Nombre;
                tipoCubrimientoEncontrado.Descripcion = tipoCubrimiento.Descripcion;
                tipoCubrimientoEncontrado.SeguroYTipoCubrimiento = tipoCubrimiento.SeguroYTipoCubrimiento;
                this._appContext.SaveChanges();
            }
            return tipoCubrimientoEncontrado;
        }
    }
}
