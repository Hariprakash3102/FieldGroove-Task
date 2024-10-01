using FieldGroove.Application.Contracts.Interface;
using FieldGroove.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldGroove.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly FieldDbContext dbcontext;

        public UnitOfWork(FieldDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
            Register = new RegistorRepository(dbcontext);
        }

        public IRegisterRepository Register {get; private set;}

        public void Dispose()
        {
            dbcontext.Dispose();
        }

        public async Task Save()
        {
           await dbcontext.SaveChangesAsync();
        }
    }
}
