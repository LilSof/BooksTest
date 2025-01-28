using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace EFDemo.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<UserBook> UserBooks { get; set; }
        public DbSet<UserBookPlan> UserBookPlan { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure LocalDB (MSSQLLocalDB)
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=BookPlanDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Book -> UserBooks relationship
            modelBuilder.Entity<UserBook>()
                .HasOne(ub => ub.Book)
                .WithMany(b => b.UserBooks)
                .HasForeignKey(ub => ub.BookId);

            // UserBook -> UserBookPlans relationship
            modelBuilder.Entity<UserBookPlan>()
                .HasOne(ubp => ubp.UserBook)
                .WithMany(ub => ub.ReadingGoals)
                .HasForeignKey(ubp => ubp.UserBookId);
        }
    }
}
