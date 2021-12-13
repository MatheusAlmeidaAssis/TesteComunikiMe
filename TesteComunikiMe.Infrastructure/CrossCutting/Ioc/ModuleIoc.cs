using Autofac;

namespace TesteComunikiMe.Infrastructure.CrossCutting.Ioc
{
    public class ModuleIoc : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            Configuration.Load(builder);
        }
    }
}