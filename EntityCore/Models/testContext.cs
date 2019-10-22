using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EntityCore.Models
{
    public partial class testContext : DbContext
    {
        public testContext()
        {
        }

        public testContext(DbContextOptions<testContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connection = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                optionsBuilder.UseMySQL(connection);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("department", "test");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasColumnName("deptName")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.ToTable("employee", "test");

                entity.HasIndex(e => e.DeptNo)
                    .HasName("DeptNo");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DeptNo).HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmpName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.DeptNoNavigation)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.DeptNo)
                    .HasConstraintName("employee_ibfk_1");
            });
        }
    }
}
