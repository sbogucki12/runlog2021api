using Microsoft.EntityFrameworkCore;

namespace runlog2021api.Models
{
    public class RunContext : DbContext
    {
        public RunContext(DbContextOptions options)
            : base(options)
        { }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Run>().Property(r => r.RunId);
        //    modelBuilder.Entity<Run>().Property(r => r.Date);
        //    modelBuilder.Entity<Run>().Property(r => r.Duration);
        //    modelBuilder.Entity<Run>().Property(r => r.RunKey);
        //    modelBuilder.Entity<Run>().Property(r => r.ImageUrl);
        //    modelBuilder.Entity<Run>().Property(r => r.Length);
        //    modelBuilder.Entity<Run>().Property(r => r.Type);
        //    modelBuilder.Entity<Run>().Property(r => r.Surface);
        //    modelBuilder.Entity<Run>().Property(r => r.Pace);
        //    modelBuilder.Entity<Run>().Property(r => r.SleepHours);
        //    modelBuilder.Entity<Run>().Property(r => r.SleepToBedTime);
        //    modelBuilder.Entity<Run>().Property(r => r.SleepWakeTime);
        //    modelBuilder.Entity<Run>().Property(r => r.RunListenedTo);
        //    modelBuilder.Entity<Run>().Property(r => r.Temperature);
        //    modelBuilder.Entity<Run>().Property(r => r.ShoeAge);
        //}

        public DbSet<Run> Runs { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
