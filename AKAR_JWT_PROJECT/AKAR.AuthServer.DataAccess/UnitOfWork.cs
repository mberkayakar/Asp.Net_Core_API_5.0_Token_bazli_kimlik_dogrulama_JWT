using AKAR.AuthServer.Core.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR.AuthServer.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {


        private  DbContext context;
     
        
        public void Commit(DbContext _dbcontext)
        {
            context = _dbcontext;
        }

        public void Commit()
        {
            context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
