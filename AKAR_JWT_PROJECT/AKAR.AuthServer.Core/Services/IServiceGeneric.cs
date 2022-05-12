using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AKAR.AuthServer.Core.Services
{
    public interface IServiceGeneric<T,TDto> where T : class where TDto : class
    {
        Task< Response<TDto>  > GetByIdAsync(string Id);
        Task< Response <IEnumerable<TDto>>> GetAllAsync();
        Task <Response <IEnumerable<TDto>>>Where(Expression<Func<T, bool>> predicate);
        Task<Response<TDto>>AddAsync(T t);
        Task<Response<NoDataDTO>> DeleteAsync(T t);
        Task<Response<NoDataDTO>>  UpdateAsync(T t);

    }
}
