using Microsoft.EntityFrameworkCore;

namespace RazorPagesLogReg.Models
{
    //The preceding code creates a DbSet property for the entity set. 
    //In Entity Framework terminology, an entity set typically corresponds to a database table, 
    //and an entity corresponds to a row in the table.
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
                : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}