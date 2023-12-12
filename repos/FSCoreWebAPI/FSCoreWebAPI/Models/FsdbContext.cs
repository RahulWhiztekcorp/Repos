using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FSCoreWebAPI.Models;

public partial class FsdbContext : DbContext
{
    public FsdbContext()
    {
    }

    public FsdbContext(DbContextOptions<FsdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-46NPMGS0\\SQLEXPRESS;Database=FSDB;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK__Departme__B2079BED1CCE16B0");

            entity.ToTable("Department");

            entity.Property(e => e.DepartmentName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04F110ACD7D25");

            entity.ToTable("Employee");

            entity.Property(e => e.DateOfJoining).HasColumnType("datetime");
            entity.Property(e => e.Department).HasMaxLength(500);
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PhotoFileName).HasMaxLength(500);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
