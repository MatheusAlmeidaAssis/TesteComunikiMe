using TesteComunikiMe.Domain.Core.Interfaces.Repositorys;
using TesteComunikiMe.Domain.Core.Interfaces.Services;
using TesteComunikiMe.Domain.Entities;

namespace TesteComunikiMe.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        public ServiceProduto(IRepositoryProduto repositoryProduto) : base(repositoryProduto)
        {
        }
    }
}