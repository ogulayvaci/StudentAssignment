using System;
using System.Collections.Generic;
using BLL.DAL;
using Microsoft.EntityFrameworkCore;

namespace BLL.Context;

public partial class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<student> students { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<student>(entity =>
        {
            entity.HasKey(e => e.id).HasName("students_pkey");

            entity.Property(e => e.birthdate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.gpa).HasPrecision(9, 1);
            entity.Property(e => e.name).HasMaxLength(50);
            entity.Property(e => e.surname).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
