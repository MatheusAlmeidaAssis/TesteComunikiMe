using TesteComunikiMe.Domain.Core.Interfaces.Repositorys;
using TesteComunikiMe.Domain.Entities;

namespace TesteComunikiMe.Infrastructure.Data.Repositorys
{
    public class RepositoryVenda : RepositoryBase<Venda>, IRepositoryVenda
    {
        public RepositoryVenda(SqlContext sqlContext) : base(sqlContext)
        {
        }
    }
}