using FieldGroove.Application.Contracts.Interface;
using FieldGroove.Domain.Models;
using FieldGroove.Infrastructure.Common;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldGroove.Infrastructure.Repositories
{
    public class RegistorRepository : GenericsRepository<RegisterModel>, IRegisterRepository
    {

        public RegistorRepository(FieldDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<RegisterModel> GetByEmail(string email)
        {
            var entity = await dbContext.RegisterDetails.FindAsync(email);

            return entity!;
        }
            
    }
}
