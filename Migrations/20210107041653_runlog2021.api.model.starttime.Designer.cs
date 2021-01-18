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
    [Migration("20210107041653_runlog2021.api.model.starttime")]
    partial class runlog2021apimodelstarttime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("runlog2021api.Models.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("ImageData")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ImageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("runlog2021api.Models.Run", b =>
                {
                    b.Property<long?>("RunId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan?>("Duration")
                        .HasColumnType("time");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Length")
                        .HasColumnType("float");

                    b.Property<TimeSpan?>("Pace")
                        .HasColumnType("time");

                    b.Property<int?>("RunKey")
                        .HasColumnType("int");

                    b.Property<string>("RunListenedTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("ShoeAge")
                        .HasColumnType("float");

                    b.Property<double?>("SleepHours")
                        .HasColumnType("float");

                    b.Property<DateTime?>("SleepToBedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("SleepWakeTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("StartTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surface")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Temperature")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RunId");

                    b.ToTable("Runs");
                });
#pragma warning restore 612, 618
        }
    }
}
