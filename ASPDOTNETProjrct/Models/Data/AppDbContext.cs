using Microsoft.EntityFrameworkCore;

namespace ASPDOTNETProjrct.Models.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed categories (positive keys are fine)
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Technology" },
                new Category { Id = 2, Name = "Health" },
                new Category { Id = 3, Name = "lifeStyle" }
            );

            // Ensure EF treats Id as value generated on add (identity)
            modelBuilder.Entity<Post>()
                .Property(p => p.Id)    // make sure your Post class uses "Id" (not "ID")
                .ValueGeneratedOnAdd();

            // Seed posts — use negative keys for seed data to avoid collisions
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = -1,
                    Title = "Tech Post 1",
                    Content = "Content of Tech Post 1",
                    Author = "John Doe",
                    PublishedDate = new DateTime(2023, 1, 1),
                    CategoryId = 1,
                    FeatureImagePath = "tech_image.jpg",
                    Description="test1"
                },
                new Post
                {
                    Id = -2,
                    Title = "Health Post 1",
                    Content = "Content of Health Post 1",
                    Author = "Jane Doe",
                    PublishedDate = new DateTime(2023, 1, 1),
                    CategoryId = 2,
                    FeatureImagePath = "health_image.jpg",
                    Description = "test2"
                },
                new Post
                {
                    Id = -3,
                    Title = "Lifestyle Post 1",
                    Content = "Content of Lifestyle Post 1",
                    Author = "Alex Smith",
                    PublishedDate = new DateTime(2023, 1, 1),
                    CategoryId = 3,
                    FeatureImagePath = "lifestyle_image.jpg",
                     Description = "test3"
                }
            );
        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }
    }
}