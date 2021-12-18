using Microsoft.EntityFrameworkCore;

namespace CodeFirstDemo.Models
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {           
            optionsBuilder.UseSqlServer("Server=.;Integrated Security=true; Database=CodeFirstDemo2021");
        }
        
        public DbSet<Category> Categories { get; set; } // name of the DB TAble 
        public DbSet<News> News { get; set; }//create models as objs and from them Tables
        public DbSet<Comment> Comments { get; set; }

    }
}
