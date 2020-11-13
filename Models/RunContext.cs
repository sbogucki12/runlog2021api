using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;
using Microsoft.EntityFrameworkCore.Query.Internal;
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
            //modelBuilder.Entity<Run>().HasData(
            //     new Run
            //     {
            //         RunId = 1,
            //         Date = new DateTime(2020, 10, 17),
            //         Duration = new TimeSpan(0, 44, 46),
            //         Length = 6.62,
            //         ImageUrl = null,
            //         Type = "not outside",
            //         Surface = "beach"
            //     }
            // );
        }



        public DbSet<Run> Runs { get; set; }
    }
}
