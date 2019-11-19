using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PoolSaison2019.Models;

namespace PoolSaison2019.Data
{
    public class PoolSaison2019Repository<T> : IRepository<T> where T : Entity
    {
        private readonly IServiceScopeFactory scopeFactory;

        public PoolSaison2019Repository(IServiceScopeFactory scopeFactory)
        {
            this.scopeFactory = scopeFactory;
        }
        public Task Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<T>> GetAll()
        {
            using(var scope = scopeFactory.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<PoolSaison2019Context>();
                var items = await dbContext.Set<T>().ToListAsync();
                return items.AsQueryable();
            }
        }

        public Task<T> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
