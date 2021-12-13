using Autofac;
using TesteComunikiMe.Application.Core.Interfaces.Map;
using TesteComunikiMe.Application.Core.Interfaces.Services;
using TesteComunikiMe.Application.Core.Map;
using TesteComunikiMe.Application.Services;
using TesteComunikiMe.Domain.Core.Interfaces.Repositorys;
using TesteComunikiMe.Domain.Core.Interfaces.Services;
using TesteComunikiMe.Domain.Services;
using TesteComunikiMe.Infrastructure.Data.Repositorys;

namespace TesteComunikiMe.Infrastructure.CrossCutting.Ioc
{
    public class Configuration
    {
        public static void Load(ContainerBuilder cotainerbuilder)
        {
            cotainerbuilder.RegisterType<AppServiceCliente>().As<IAppServiceCliente>();
            cotainerbuilder.RegisterType<AppServiceProduto>().As<IAppServiceProduto>();
            cotainerbuilder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            cotainerbuilder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            cotainerbuilder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            cotainerbuilder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            cotainerbuilder.RegisterType<MapCliente>().As<IMapCliente>();
            cotainerbuilder.RegisterType<MapProduto>().As<IMapProduto>();
            cotainerbuilder.RegisterType<AppServiceVenda>().As<IAppServiceVenda>();
            cotainerbuilder.RegisterType<AppServiceVenda>().As<IAppServiceVenda>();
            cotainerbuilder.RegisterType<ServiceVenda>().As<IServiceVenda>();
            cotainerbuilder.RegisterType<ServiceVendaDetalhe>().As<IServiceVendaDetalhe>();
            cotainerbuilder.RegisterType<RepositoryVenda>().As<IRepositoryVenda>();
            cotainerbuilder.RegisterType<RepositoryVendaDetalhe>().As<IRepositoryVendaDetalhe>();
            cotainerbuilder.RegisterType<MapVenda>().As<IMapVenda>();
            cotainerbuilder.RegisterType<MapVendaDetalhe>().As<IMapVendaDetalhe>();
        }
    }
}