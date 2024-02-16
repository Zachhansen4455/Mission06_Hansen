using Microsoft.EntityFrameworkCore;

namespace Mission06_Hansen.Models
{
    public class FormContext : DbContext
    {
        public FormContext(DbContextOptions<FormContext> options) : base (options) 
        { 
        }

        public DbSet<Form> Forms { get; set; }
    }
}
