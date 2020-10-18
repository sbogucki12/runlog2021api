using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;
using System;

namespace runlog2021api.Models
{
    public class RunContext : DbContext
    {
        public RunContext(DbContextOptions options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Run>().HasData(
                new Run
                {
                    RunId = 1,
                    Date = new DateTime(2020, 10, 17),
                    Duration = new TimeSpan(0, 44, 46),
                    Length = 6.62
                },
                new Run
                {
                    RunId = 2,
                    Date = new DateTime(2020, 10, 16),
                    Duration = new TimeSpan(0, 37, 21),
                    Length = 5.34
                }
            );
        }



        public DbSet<Run> Runs { get; set; }
    }
}
