using TesteComunikiMe.Domain.Core.Interfaces.Repositorys;
using TesteComunikiMe.Domain.Core.Interfaces.Services;
using TesteComunikiMe.Domain.Entities;

namespace TesteComunikiMe.Domain.Services
{
    public class ServiceVenda : ServiceBase<Venda>, IServiceVenda
    {
        public ServiceVenda(IRepositoryVenda repositoryVenda) : base(repositoryVenda)
        {
        }
    }
}