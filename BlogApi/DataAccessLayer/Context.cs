using Microsoft.EntityFrameworkCore;

namespace BlogApi.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-28DRIHF\\SQLEXPRESS;Trusted_Connection=True;database=CoreBlogApiDb;" +
                "integrated security=true;");


        }
        public DbSet<Employee> Employee { get; set; }
    }
}
