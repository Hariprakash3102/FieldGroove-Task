using FieldGroove.Application.Contracts.Interface;
using FieldGroove.Infrastructure.Common;
using Microsoft.EntityFrameworkCore;
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

        protected readonly FieldDbContext dbContext;

        public GenericsRepository(FieldDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(T entity)
        {
            await dbContext.Set<T>().AddAsync(entity);
            await dbContext.SaveChangesAsync();

        }

        public async Task Delete(int id)
        {
            var delete = await GetById(id);

            if(delete != null)
            {
                dbContext.Set<T>().Remove(delete);
                await dbContext.SaveChangesAsync(); 
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
           var entity = await dbContext.Set<T>().FindAsync(id);

            return entity!;
        }

        public async Task Update(T entity)
        {
             dbContext.Set<T>().Update(entity);
             await dbContext.SaveChangesAsync();
        }
    }
}
