using enuzTranslatorBegin.MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace enuzTranslatorBegin.MVC.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {
        }


        public DbSet<Enuz> Enuzs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enuz>().HasKey(e => e.Id);
        }
    }
}
