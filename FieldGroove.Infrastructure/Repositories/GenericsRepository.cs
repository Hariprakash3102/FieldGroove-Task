using FieldGroove.Application.Contracts.Interface;
using FieldGroove.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FieldGroove.Infrastructure.Repositories
{
    public class GenericsRepository<T> : IGenericsRepository<T> where T : class
    {

        private readonly FieldDbContext dbContext;

        public GenericsRepository(FieldDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(T entity)
        {
           return await dbContext.AddAsync(entity);
        }

        public Task Delete(Guid id)
        {
            
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
