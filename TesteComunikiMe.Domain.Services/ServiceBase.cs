using System.Collections.Generic;
using System.Threading.Tasks;
using TesteComunikiMe.Domain.Core.Interfaces.Repositorys;
using TesteComunikiMe.Domain.Core.Interfaces.Services;
using TesteComunikiMe.Domain.Entities;

namespace TesteComunikiMe.Domain.Services
{
    public class ServiceBase<Entity> : IServiceBase<Entity> where Entity : EntityBase
    {
        protected readonly IRepositoryBase<Entity> _repository;

        public ServiceBase(IRepositoryBase<Entity> repository)
        {
            _repository = repository;
        }

        public async Task<Entity> Add(Entity entity)
        {
            return await _repository.Add(entity);
        }

        public IEnumerable<Entity> Get()
        {
            return _repository.Get();
        }

        public Entity Get(int id)
        {
            return _repository.Get(id);
        }

        public async Task<Entity> Remove(int id)
        {
            return await _repository.Remove(id);
        }

        public async Task<Entity> Update(Entity entity)
        {
            return await _repository.Update(entity);
        }
    }
}