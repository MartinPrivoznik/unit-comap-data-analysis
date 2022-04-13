using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
using UnIT_ComAp.Models;
using UnIT_ComAp.Models.DbModel;

namespace UnIT_ComAp.Data
{
    public class ReportsDatabase : DbContext
    {
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestGroup> TestGroups { get; set; }
        public DbSet<TestHead> TestHeads { get; set; }
        public DbSet<TestOperation> TestOperations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=TestDatabase.db", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });

            SQLitePCL.Batteries.Init();

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestHead>().ToTable("Heads").HasData(
                new TestHead() 
                { 
                    Id = 1,
                    Success = true,
                    DateSOfTesting = System.DateTime.Now,
                    ProductSN = "xxx",
                    ProductName = "xxx"
                });

            modelBuilder.Entity<TestHead>().HasKey(c => new
            {
                c.Id,
            });


            modelBuilder.Entity<Test>().ToTable("Tests").HasData(
                new Test()
                {
                    Id = 1,
                    HeadId = 1,
                    Title = "Test test",
                    GroupId = 1
                });
            modelBuilder.Entity<Test>().HasKey(c => new
            {
                c.HeadId,
                c.Id,
                c.GroupId
            });

            modelBuilder.Entity<TestGroup>().ToTable("Groups").HasData(
                new TestGroup()
                {
                    Id = 1,
                    HeadId = 1,
                    Success = true
                });
            modelBuilder.Entity<TestGroup>().HasKey(c => new
            {
                c.HeadId,
                c.Id,
            });

            modelBuilder.Entity<TestOperation>().ToTable("Operations").HasData(
                new TestOperation()
                {
                    HeadId = 1,
                    TestId = 1,
                    Id = 1,
                    GroupId = 1,
                    Name = "Analog value Ch1 (ohm)",
                    Type = "check",
                    Value = "10307.0922",
                    ExpectedHigh = "10815",
                    ExpectedLow = "9785",
                    Result = "OK"
                },
                new TestOperation()
                {
                    HeadId = 1,
                    TestId = 1,
                    Id = 2,
                    GroupId = 1,
                    Type = "info",
                    Text = "No HID device found"
                });
            modelBuilder.Entity<TestOperation>().HasKey(c => new
            {
                c.Id,
                c.HeadId,
                c.TestId,
                c.GroupId
            });


            base.OnModelCreating(modelBuilder);
        }
    }
}
