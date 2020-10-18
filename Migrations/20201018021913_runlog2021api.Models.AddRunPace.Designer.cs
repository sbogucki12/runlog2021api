﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using runlog2021api.Models;

namespace runlog2021api.Migrations
{
    [DbContext(typeof(RunContext))]
    [Migration("20201018021913_runlog2021api.Models.AddRunPace")]
    partial class runlog2021apiModelsAddRunPace
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("runlog2021api.Models.Run", b =>
                {
                    b.Property<long>("RunId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<double>("Length")
                        .HasColumnType("float");

                    b.Property<TimeSpan>("Pace")
                        .HasColumnType("time");

                    b.HasKey("RunId");

                    b.ToTable("Runs");

                    b.HasData(
                        new
                        {
                            RunId = 1L,
                            Date = new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Duration = new TimeSpan(0, 0, 44, 46, 0),
                            Length = 6.6200000000000001,
                            Pace = new TimeSpan(4057401813)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
