using TesteComunikiMe.Domain.Core.Interfaces.Repositorys;
using TesteComunikiMe.Domain.Core.Interfaces.Services;
using TesteComunikiMe.Domain.Entities;

namespace TesteComunikiMe.Domain.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        public ServiceCliente(IRepositoryCliente repositoryCliente) : base(repositoryCliente)
        {
        }
    }
}