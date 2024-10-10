using FieldGroove.Application.Contracts.Interface;
using FieldGroove.Domain.Models;
using FieldGroove.Infrastructure.Common;
using Microsoft.EntityFrameworkCore; 

namespace FieldGroove.Infrastructure.Repositories
{
    public class RegistorRepository : GenericsRepository<RegisterModel>, IRegisterRepository
    {

        public RegistorRepository(FieldDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<RegisterModel> GetByEmail(string email)
        {
            var entity = await dbContext.RegisterDetails.FirstOrDefaultAsync(x=>x.Email==email);
            return entity!;

           
        }
            
    }
}
