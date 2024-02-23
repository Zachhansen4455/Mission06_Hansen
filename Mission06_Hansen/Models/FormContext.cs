using Microsoft.EntityFrameworkCore;

namespace Mission06_Hansen.Models
{
    public class FormContext : DbContext
    {
        public FormContext(DbContextOptions<FormContext> options) : base (options) 
        { 
        }

        public DbSet<Form> Forms { get; set; }
        public DbSet<Movie> Movies { get; set; }
        
        public DbSet<Category> Categories { get; set; } //second table in db
        
        protected override void OnModelCreating(ModelBuilder modelBuilder) //seed data
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName="Miscellaneuos"},
                new Category { CategoryId = 2, CategoryName = "Drama" },
                new Category { CategoryId = 3, CategoryName = "Television" },
                new Category { CategoryId = 4, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 5, CategoryName = "Comdedy" },
                new Category { CategoryId = 6, CategoryName = "Family" },
                new Category { CategoryId = 7, CategoryName = "Action/Adventure" },
                new Category { CategoryId = 8, CategoryName = "VHS" }
            );
        }
    }
}
