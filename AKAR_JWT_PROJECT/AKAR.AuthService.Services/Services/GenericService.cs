using AKAR.AuthServer.Core.Services;
using AKAR.AuthServer.Core.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AKAR.AuthService.Services.Services
{
    public class GenericService<T, TDto> : IServiceGeneric<T, TDto> where T : class where TDto : class
    {
        private readonly IUnitOfWork _unitOfWork;
 
            
            
            
        public Task<Response<TDto>> GetByIdAsync(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<IEnumerable<TDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<IEnumerable<TDto>>> Where(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Response<TDto>> AddAsync(T t)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoDataDTO>> DeleteAsync(T t)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoDataDTO>> UpdateAsync(T t)
        {
            throw new NotImplementedException();
        }
    }
}
