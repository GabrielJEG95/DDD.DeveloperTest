using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DDD.TestDeveloperTestDomain.Entidades
{
    public partial class DDDTestDeveloperContext : DbContext
    {
        public DDDTestDeveloperContext()
        {
        }

        public DDDTestDeveloperContext(DbContextOptions<DDDTestDeveloperContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Division> Divisions { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Office> Offices { get; set; } = null!;
        public virtual DbSet<Position> Positions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Division>(entity =>
            {
                entity.HasKey(e => e.IdDivision)
                    .HasName("PK__Division__542428D0B88F2D76");

                entity.ToTable("Division");

                entity.Property(e => e.Division1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Division");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employee");

                entity.Property(e => e.BaseSalary).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.BeginDate).HasColumnType("date");

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.Commision).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.CompensationBonus).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Contributions).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeSurname)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IdentificationNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionBonus).HasColumnType("decimal(8, 2)");

                entity.HasOne(d => d.DivisionNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.Division)
                    .HasConstraintName("FK__employee__Divisi__2B3F6F97");

                entity.HasOne(d => d.OfficeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.Office)
                    .HasConstraintName("FK__employee__Office__2A4B4B5E");

                entity.HasOne(d => d.PositionNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.Position)
                    .HasConstraintName("FK__employee__Positi__2C3393D0");
            });

            modelBuilder.Entity<Office>(entity =>
            {
                entity.HasKey(e => e.IdOffice)
                    .HasName("PK__Office__57A12F4F8F13ACFE");

                entity.ToTable("Office");

                entity.Property(e => e.Office1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Office");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.HasKey(e => e.IdPosition)
                    .HasName("PK__Position__DF67EA4CD16E5CD0");

                entity.ToTable("Position");

                entity.Property(e => e.Position1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Position");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
