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
            modelBuilder.Entity<TestHead>().ToTable("Heads");
            modelBuilder.Entity<TestHead>().HasKey(c => new
            {
                c.Id,
            });

            // Map table names
            modelBuilder.Entity<Test>().ToTable("Tests");
            modelBuilder.Entity<Test>().HasKey(c => new
            {
                c.HeadId,
                c.Id,
                c.GroupId
            });

            modelBuilder.Entity<TestGroup>().ToTable("Groups");
            modelBuilder.Entity<TestGroup>().HasKey(c => new
            {
                c.HeadId,
                c.Id,
            });

            modelBuilder.Entity<TestOperation>().ToTable("Operations");
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
