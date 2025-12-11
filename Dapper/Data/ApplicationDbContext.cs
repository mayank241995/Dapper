using Dapper.Models;
using Microsoft.EntityFrameworkCore;

namespace Dapper.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Company> Companies { get; set; }
    }
}
