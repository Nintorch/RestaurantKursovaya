using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace App.Data
{
    public partial class RestaurantContext : DbContext
    {
        public RestaurantContext()
        {
        }

        public RestaurantContext(DbContextOptions<RestaurantContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administator> Administrators { get; set; } = null!;
        public virtual DbSet<SickPeriod> SickPeriods { get; set; } = null!;
        public virtual DbSet<Award> Awards { get; set; } = null!;
        public virtual DbSet<OvertimePeriod> OvertimePeriods { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Fine> Fines { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\;Database=Зарплаты;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administator>(entity =>
            {
                entity.HasKey(e => e.Login);

                entity.ToTable("Администраторы");

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .HasColumnName("login");

                entity.Property(e => e.Passwordhash)
                    .HasMaxLength(128)
                    .HasColumnName("passwordhash");
            });

            modelBuilder.Entity<SickPeriod>(entity =>
            {
                entity.HasKey(e => e.ID);

                entity.ToTable("Больничные$");

                entity.Property(e => e.EmployeeID).HasColumnName("ID");

                entity.Property(e => e.ID)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID больничного");

                entity.Property(e => e.DateEnd)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Конец больничного периода");

                entity.Property(e => e.DateStart)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Начало больничного периода");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("Причина (опционально)");
            });

            modelBuilder.Entity<Award>(entity =>
            {
                entity.HasKey(e => e.ID);

                entity.ToTable("Премии$");

                entity.Property(e => e.ID).HasColumnName("ID премии");

                entity.Property(e => e.EmployeeID).HasColumnName("ID");

                entity.Property(e => e.AwardDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Дата получения");

                entity.Property(e => e.Reason)
                    .HasMaxLength(250)
                    .HasColumnName("Причина премии");

                entity.Property(e => e.AmountInRubles).HasColumnName("Сумма (в рублях)");

                entity.HasOne(d => d.EmployeeNavigation)
                    .WithMany(p => p.Awards)
                    .HasForeignKey(d => d.EmployeeID)
                    .HasConstraintName("FK_Премии$_Сотрудники$");
            });

            modelBuilder.Entity<OvertimePeriod>(entity =>
            {
                entity.HasKey(e => e.ID);

                entity.ToTable("'Сверхурочные часы$'");

                entity.Property(e => e.ID).HasColumnName("ID периода");

                entity.Property(e => e.EmployeeID).HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Дата");

                entity.Property(e => e.OvertimeHoursCount).HasColumnName("Количество сверхурочных часов");

                entity.HasOne(d => d.EmployeeNavigation)
                    .WithMany(p => p.OvertimePeriods)
                    .HasForeignKey(d => d.EmployeeID)
                    .HasConstraintName("FK_'Сверхурочные часы$'_Сотрудники$");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Сотрудники$");

                entity.Property(e => e.ID).HasColumnName("ID");

                entity.Property(e => e.BaseSalaryPerHourInRubles).HasColumnName("Базовая зарплата (в рублях в час)");

                entity.Property(e => e.RoleWorkStartDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Время начала работы на этой должности");

                entity.Property(e => e.Birthday)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Дата рождения");

                entity.Property(e => e.Role)
                    .HasMaxLength(255)
                    .HasColumnName("Должность");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("Имя");

                entity.Property(e => e.WorkDaysPerWeek).HasColumnName("Количество рабочих дней в неделю");

                entity.Property(e => e.WorkHoursPerDay).HasColumnName("Количество часов работы в день");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(255)
                    .HasColumnName("Отчество");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("Фамилия");
            });

            modelBuilder.Entity<Fine>(entity =>
            {
                entity.HasKey(e => e.ID);

                entity.ToTable("Штрафы$");

                entity.Property(e => e.ID).HasColumnName("ID штрафа");

                entity.Property(e => e.EmployeeID).HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Дата получения");

                entity.Property(e => e.GiverID).HasColumnName("Кем выдан, ID");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("Причина получения");

                entity.Property(e => e.Amount).HasColumnName("Сумма");

                entity.HasOne(d => d.EmployeeNavigation)
                    .WithMany(p => p.Fines)
                    .HasForeignKey(d => d.EmployeeID)
                    .HasConstraintName("FK_Штрафы$_Сотрудники$");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
