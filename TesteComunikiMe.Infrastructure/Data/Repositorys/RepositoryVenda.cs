using System;
using System.Linq;
using System.Threading.Tasks;
using TesteComunikiMe.Domain.Core.Interfaces.Repositorys;
using TesteComunikiMe.Domain.Entities;

namespace TesteComunikiMe.Infrastructure.Data.Repositorys
{
    public class RepositoryVenda : RepositoryBase<Venda>, IRepositoryVenda
    {
        private readonly IRepositoryProduto _repositoryProduto;

        public RepositoryVenda(SqlContext sqlContext, IRepositoryProduto repositoryProduto) : base(sqlContext)
        {
            _repositoryProduto = repositoryProduto;
        }

        public override async Task<Venda> Add(Venda entity)
        {
            var venda = await base.Add(entity);
            foreach (var item in venda.VendaDetalhes)
            {
                item.Produto.QuantidadeEstoque -= item.Quantidade;
                await _repositoryProduto.Update(item.Produto);
            }
            return venda;
        }

        public override async Task<Venda> Update(Venda entity)
        {
            var venda = Get(entity.Id);
            var itensVenda = venda.VendaDetalhes.ToList();
            var vendaAlterada = await base.Update(entity);
            foreach (var item in vendaAlterada.VendaDetalhes)
            {
                var itemVenda = itensVenda.FirstOrDefault(p => p.Id == item.Id);
                var difQuantidade = itemVenda.Quantidade - item.Quantidade;
                item.Produto.QuantidadeEstoque = difQuantidade > 0 ? item.Produto.QuantidadeEstoque + difQuantidade : item.Produto.QuantidadeEstoque - difQuantidade;
                await _repositoryProduto.Update(item.Produto);
            }
            return vendaAlterada;
        }

        public override async Task<Venda> Remove(int id)
        {
            var venda = await base.Remove(id);
            foreach (var item in venda.VendaDetalhes)
            {
                item.DataExclusao = DateTime.Now;
                _sqlContext.Set<VendaDetalhe>().Update(item);
                await _sqlContext.SaveChangesAsync();
            }
            return venda;
        }
    }
}