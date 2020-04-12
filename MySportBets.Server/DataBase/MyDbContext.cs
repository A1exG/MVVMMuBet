using Microsoft.EntityFrameworkCore;
using MySportBets.Model.Model;

namespace MySportBets.Server.DataBase
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        //public DbSet<Bet> Bets { get; set; }
        //public DbSet<SportEvent> SportEvents { get; set; }
        //public DbSet<HistorySportEvent> HistorySportEvents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-RH4I9L4\SQLEXPRESS;Database=SportBetDb;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users").HasKey(p => p.UserId);
            //modelBuilder.Entity<Bet>().ToTable("Bets").HasKey(p => p.BetId);
            //modelBuilder.Entity<SportEvent>().ToTable("SportEvents").HasKey(p => p.SportEventId);
            //modelBuilder.Entity<HistorySportEvent>().ToTable("HistorySportEvents").HasKey(p => p.HistorySportEventId);
        }
    }
}