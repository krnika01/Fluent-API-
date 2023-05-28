using Karnika_Panoriya_Assignment.Model;
using Microsoft.EntityFrameworkCore;

namespace Karnika_Panoriya_Assignment.Data
{
    public class DatabaseContext : DbContext

    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentModel>(entity =>
            {
                entity.Property(e => e.Address)
                .IsRequired();

                entity.Property(e => e.Mobile)
                .IsRequired();

                entity.Property(e => e.FirstName)
                .HasColumnName("Name");

            });

            modelBuilder.Entity<StudentModel>().ToTable("Student_data");

            modelBuilder.Entity<StudentModel>().ToTable("Student_data" , "Ideal");


        }
        public DbSet<StudentModel> studentModels { get; set; }
    }
}
