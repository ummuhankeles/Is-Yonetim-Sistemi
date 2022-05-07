using System;
using IsYonetimSistemi.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace IsYonetimSistemi.Dal.Concrete.EntityFramework.Context
{
    public partial class IsYonetimSistemiContext : DbContext
    {
        //IConfiguration configuration;

        //public IsYonetimSistemiContext(IConfiguration configuration)
        //{
        //    this.configuration = configuration;
        //}

        public IsYonetimSistemiContext()
        {
        }

        public IsYonetimSistemiContext(DbContextOptions<IsYonetimSistemiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Personel> Personels { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<TaskDetail> TaskDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer(configuration.GetConnectionString("SqlServer"));

                optionsBuilder.UseSqlServer("Server=UMMUHANKELES\\SQLEXPRESS;Database=IsYonetimSistemi;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("department_name");
            });

            modelBuilder.Entity<Personel>(entity =>
            {
                entity.ToTable("Personel");

                entity.Property(e => e.PersonelId).HasColumnName("personel_id");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.PersonelEmail)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("personel_email");

                entity.Property(e => e.PersonelName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("personel_name");

                entity.Property(e => e.PersonelPassword)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("personel_password");

                entity.Property(e => e.PersonelPhone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("personel_phone");

                entity.Property(e => e.PersonelSurname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("personel_surname");

                entity.Property(e => e.RoleId).HasColumnName("role_id");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("role_name");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("Task");

                entity.Property(e => e.TaskId).HasColumnName("task_id");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.PersonelId).HasColumnName("personel_id");

                entity.Property(e => e.TaskDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("task_description");

                entity.Property(e => e.TaskPriority)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("task_priority");

                entity.Property(e => e.TaskTitle)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("task_title");
            });

            modelBuilder.Entity<TaskDetail>(entity =>
            {
                entity.ToTable("TaskDetail");

                entity.Property(e => e.TaskDetailId).HasColumnName("taskDetail_id");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TaskDetailDescription)
                    .IsRequired()
                    .HasColumnName("taskDetail_description");

                entity.Property(e => e.TaskId).HasColumnName("task_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
