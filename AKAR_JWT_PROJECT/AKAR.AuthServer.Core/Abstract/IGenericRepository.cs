using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AKAR.AuthServer.Core.Abstract
{
    public interface IGenericRepository <T> where T : class
    {
        Task<T> GetByIdAsync (string Id);
        Task<IEnumerable<T>> GetAllAsync ();
        IQueryable<T> Where(Expression<Func<T, bool>> predicate);

        void AddAsync(T t);
        void DeleteAsync(T t);
        T UpdateAsync(T t);

         
    }
}
