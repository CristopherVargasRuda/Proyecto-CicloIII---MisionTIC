using System;
using Impresoras3D.App.Dominio;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Impresoras3D.App.Persistencia
{
    public class RepositorioCompraSeguro : IRepositorioCompraSeguro
    {
        private readonly AppContext _appContext;

        public RepositorioCompraSeguro(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public CompraSeguro AddCompraSeguro(CompraSeguro compraSeguro)
        {
            var compraSeguroAdicionado = this._appContext.CompraSeguros.Add(compraSeguro);
            this._appContext.SaveChanges();
            return compraSeguroAdicionado.Entity;
        }

        public void DeleteCompraSeguro(int idCompraSeguro)
        {
            var compraSeguro = this._appContext.CompraSeguros.FirstOrDefault(
                c => c.Id == idCompraSeguro
            );

            if (compraSeguro == null)
            {
                return;
            }
            this._appContext.CompraSeguros.Remove(compraSeguro);
            this._appContext.SaveChanges();
        }

        public CompraSeguro getCompraSeguro(int idCompraSeguro)
        {
            var compraSeguro = this._appContext.CompraSeguros.FirstOrDefault(
                c => c.Id == idCompraSeguro
            );
            return compraSeguro;
        }

        public IEnumerable<CompraSeguro> GetAllCompraSeguro()
        {
            return this._appContext.CompraSeguros;
        }

        public CompraSeguro UpdateCompraSeguro(CompraSeguro compraSeguro)
        {
            var compraSeguroEncontrado = this._appContext.CompraSeguros.FirstOrDefault(
                c => c.Id == compraSeguro.Id
            );

            if (compraSeguroEncontrado != null)
            {
                compraSeguroEncontrado.FechaCompra = compraSeguro.FechaCompra;
                compraSeguroEncontrado.FechaVencimiento = compraSeguro.FechaVencimiento;
                compraSeguroEncontrado.ImpresoraId = compraSeguro.ImpresoraId;
                compraSeguroEncontrado.SeguroId = compraSeguro.SeguroId;
                this._appContext.SaveChanges();
            }
            return compraSeguroEncontrado;
        }

        public CompraSeguro getCompraSeguroByImpresoraId(int ImpresoraId)
        {
                var compraSegurosObtenidos = this._appContext.CompraSeguros.FromSqlRaw(
                    @"SELECT cs.Id, cs.FechaCompra, cs.FechaVencimiento, cs.ImpresoraId, cs.SeguroId FROM dbo.Compra_seguro cs WHERE ImpresoraId = {0} Order By Id desc", ImpresoraId
                    ).FirstOrDefault();

            return compraSegurosObtenidos;
        }
    }
}
