using System.Collections.Generic;
using System.Threading.Tasks;
using TesteComunikiMe.Domain.Entities;

namespace TesteComunikiMe.Domain.Core.Interfaces.Services
{
    public interface IServiceBase<Entity> where Entity : EntityBase
    {
        Task<Entity> Add(Entity entity);

        Task<Entity> Update(Entity entity);

        Task<Entity> Remove(int id);

        IEnumerable<Entity> Get();

        Entity Get(int id);
    }
}