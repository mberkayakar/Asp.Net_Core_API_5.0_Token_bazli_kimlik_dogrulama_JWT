using AKAR.AuthServer.Core.Abstract;
using AKAR.AuthServer.DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AKAR.AuthServer.DataAccess.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class 
    {
        private readonly DbContext dbContext;
        private DbSet<T> _dbset;

        public GenericRepository(MyDbContext contex)
        {
            dbContext = contex;
            _dbset = contex.Set<T>();
        }

        public void AddAsync(T t)
        {
            _dbset.Add(t);
        }

        public void DeleteAsync(T t)
        {
            _dbset.Remove(t);

        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbset.ToListAsync();  
        }

        public async Task<T> GetByIdAsync(string Id)
        {
            var entity = await _dbset.FindAsync(Id);
            if (entity != null)
            {
                dbContext.Entry(entity).State = EntityState.Detached;
            }
            return entity;

        }

        public T UpdateAsync(T t)
        {
            dbContext.Entry(t).State = EntityState.Modified;
            return t;
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        {
            return _dbset.Where(predicate);
        }
    }
}
