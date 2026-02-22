using Microsoft.EntityFrameworkCore;

namespace ASPDOTNETProjrct.Models.Data
{
    public class AppDbContext : DbContext
    {
        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        //{


        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configuring the connection string to use a SQL Server database.
            // UseSqlServer is an extension method that configures the context to connect to a SQL Server database.
            optionsBuilder.UseSqlServer(@"Server=HP\SQLEXPRESS;Database=MVCTestApplication;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }

}

