using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DiaryApp.Data
{
    public class ApplicationDBContext : DbContext
    {
        // Constructor to connect to the DbContext & tap into the DB
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options) 
        {
        }

        // create a DbSet for migration every time you create a new model
        public DbSet<DiaryEntry> DiaryEntries { get; set; } // create a diary-entry table
        public DbSet<Users> Users { get; set; } // create users table


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
             new DiaryEntry
             {
                 Id = 11,
                 Title = "Went Shoppings",
                 Description = "Shoppings at the biggest mall in Istanbul is amazing.",
                 CreatedAt = new DateTime(2025, 9, 5),
                 UpdatedAt = new DateTime(2025, 9, 5)
             }
            );
        }
    }
}



//TODO:
//1. create a Model Class
//2. Add DB Set
//3. add-migration AddDiaryEntryTable/AddUsersTable
//4. Update-database
