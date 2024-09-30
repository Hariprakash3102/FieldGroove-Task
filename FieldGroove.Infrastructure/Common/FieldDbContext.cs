using FieldGroove.Domain.Models;
using Microsoft.EntityFrameworkCore; 

namespace FieldGroove.Infrastructure.Common
{
    public class FieldDbContext : DbContext
    {
        public FieldDbContext(DbContextOptions<FieldDbContext> options) : base(options)
        {
        }

        public DbSet<RegisterModel> RegisterDetails { get; set; }
    }
}
