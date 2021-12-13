using TesteComunikiMe.Domain.Core.Interfaces.Repositorys;
using TesteComunikiMe.Domain.Core.Interfaces.Services;
using TesteComunikiMe.Domain.Entities;

namespace TesteComunikiMe.Domain.Services
{
    public class ServiceVendaDetalhe : ServiceBase<VendaDetalhe>, IServiceVendaDetalhe
    {
        public ServiceVendaDetalhe(IRepositoryVendaDetalhe repositoryVendaDetalhe) : base(repositoryVendaDetalhe)
        {
        }
    }
}