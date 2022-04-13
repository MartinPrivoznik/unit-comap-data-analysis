using Microsoft.EntityFrameworkCore;
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
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map table names
            modelBuilder.Entity<Test>().ToTable("Reports");
            modelBuilder.Entity<Test>().HasKey(c => new
            {
                c.HeadId,
                c.Id,
                c.GroupId
            });

            modelBuilder.Entity<TestGroup>().ToTable("Reports");
            modelBuilder.Entity<TestGroup>().HasKey(c => new
            {
                c.HeadId,
                c.Id,
            });

            modelBuilder.Entity<TestHead>().ToTable("Reports");
            modelBuilder.Entity<TestHead>().HasKey(c => new
            {
                c.Id,
            });

            modelBuilder.Entity<TestOperation>().ToTable("Reports");
            modelBuilder.Entity<TestOperation>().HasKey(c => new
            {
                c.HeadId,
                c.TestId,
                c.GroupId
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
