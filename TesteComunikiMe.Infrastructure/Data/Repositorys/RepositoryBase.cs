using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteComunikiMe.Domain.Core.Interfaces.Repositorys;
using TesteComunikiMe.Domain.Entities;

namespace TesteComunikiMe.Infrastructure.Data.Repositorys
{
    public class RepositoryBase<Entity> : IRepositoryBase<Entity> where Entity : EntityBase
    {
        protected readonly SqlContext _sqlContext;

        private IEnumerable<Entity> Entities
        {
            get
            {
                return _sqlContext.Set<Entity>()
                    .Where(p => !p.DataExclusao.HasValue)
                    .ToList();
            }
        }

        public RepositoryBase(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public async Task<Entity> Add(Entity entity)
        {
            try
            {
                await _sqlContext.Set<Entity>().AddAsync(entity);
                await _sqlContext.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Entity> Get()
        {
            return Entities;
        }

        public async Task<Entity> Get(int id)
        {
            return await _sqlContext.Set<Entity>().FindAsync(id);
        }

        public async Task<Entity> Remove(int id)
        {
            try
            {
                var entity = await Get(id);
                entity.DataExclusao = DateTime.Now;
                _sqlContext.Set<Entity>().Update(entity);
                await _sqlContext.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Entity> Update(Entity entity)
        {
            try
            {
                _sqlContext.Set<Entity>().Update(entity);
                await _sqlContext.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}