using TesteComunikiMe.Domain.Core.Interfaces.Repositorys;
using TesteComunikiMe.Domain.Entities;

namespace TesteComunikiMe.Infrastructure.Data.Repositorys
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        public RepositoryProduto(SqlContext sqlContext) : base(sqlContext)
        {
        }
    }
}