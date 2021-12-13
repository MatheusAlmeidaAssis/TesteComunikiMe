using TesteComunikiMe.Domain.Core.Interfaces.Repositorys;
using TesteComunikiMe.Domain.Entities;

namespace TesteComunikiMe.Infrastructure.Data.Repositorys
{
    public class RepositoryVendaDetalhe : RepositoryBase<VendaDetalhe>, IRepositoryVendaDetalhe
    {
        public RepositoryVendaDetalhe(SqlContext sqlContext) : base(sqlContext)
        {
        }
    }
}