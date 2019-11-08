using Microsoft.EntityFrameworkCore;
using SharedLibrary.Models.Entities;

namespace DataAccessLayer.EF
{
    public class VacationPracticeDbContext : DbContext
    {
        public VacationPracticeDbContext(DbContextOptions options) : base(options)
        {
            ChangeTracker.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigurationEmployee(modelBuilder);
            ConfigurationLeave(modelBuilder);
        }

        private static void ConfigurationEmployee(ModelBuilder modelBuilder)
        {
            var entityTypeBuilder = modelBuilder.Entity<Employee>();
            entityTypeBuilder.HasKey(e => e.Id);

            entityTypeBuilder.Property(e => e.Id)
                             .ValueGeneratedOnAdd();
            entityTypeBuilder.Property(e => e.Name)
                             .HasMaxLength(20)
                             .IsUnicode(false)
                             .IsRequired();
            entityTypeBuilder.Property(e => e.AnnualLeave)
                             .HasDefaultValue(0)
                             .IsRequired();
            entityTypeBuilder.Property(e => e.RemainAnnual)
                             .HasDefaultValue(0)
                             .IsRequired();
            entityTypeBuilder.Property(e => e.OnBoardDate)
                             .HasColumnType(SqlType.Date)
                             .IsRequired();
            entityTypeBuilder.Property(e => e.BirthDay)
                             .HasColumnType(SqlType.Date)
                             .IsRequired();
            entityTypeBuilder.Property(e => e.Phone)
                             .HasMaxLength(10)
                             .IsUnicode(false)
                             .IsRequired();
        }

        private static void ConfigurationLeave(ModelBuilder modelBuilder)
        {
            var entityTypeBuilder = modelBuilder.Entity<Leave>();
            entityTypeBuilder.HasKey(e => e.Id);

            entityTypeBuilder.Property(e => e.Id)
                             .ValueGeneratedOnAdd();
            entityTypeBuilder.Property(e => e.EmployeeId)
                             .IsRequired();
            entityTypeBuilder.Property(e => e.Kind)
                             .IsRequired();
            entityTypeBuilder.Property(e => e.LeaveStart)
                             .HasColumnType(SqlType.Date)
                             .IsRequired();
            entityTypeBuilder.Property(e => e.LeaveEnd)
                             .HasColumnType(SqlType.Date)
                             .IsRequired();
            entityTypeBuilder.Property(e => e.LeaveTime)
                             .IsRequired();
            entityTypeBuilder.Property(e => e.Reason)
                             .HasMaxLength(100)
                             .IsUnicode(true)
                             .IsRequired();
        }
        
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Leave> Leaves { get; set; }
    }
}