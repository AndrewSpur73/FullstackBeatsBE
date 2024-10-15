using Microsoft.EntityFrameworkCore;
using FullstackBeatsBE.Models;
using FullstackBeatsBE.Data;

namespace FullstackBeatsBE
{
    public class FullstackBeatsBEDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Show> Shows { get; set; }

        public FullstackBeatsBEDbContext(DbContextOptions<FullstackBeatsBEDbContext> context) : base(context)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(UserData.Users);
            modelBuilder.Entity<Category>().HasData(CategoryData.Categories);
            modelBuilder.Entity<Show>().HasData(ShowData.Shows);

            modelBuilder.Entity<Show>()
                .HasMany(s => s.Attendee)
                .WithMany(u => u.WatchShow)
                .UsingEntity(t => t.ToTable("UserShow"));

            modelBuilder.Entity<Show>()
                .HasOne(s => s.Host)           
                .WithMany(u => u.HostShow)    
                .HasForeignKey(s => s.HostId);


        }
    }
}
