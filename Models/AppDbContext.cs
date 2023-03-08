using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VMSApi.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Guest> Guests { get; set; }

    public virtual DbSet<Visit> Visits { get; set; }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
    //     //=> optionsBuilder.UseSqlServer("Name=ConnectionStrings:VMS");
    //     var configuration = new ConfigurationBuilder()
    //     .SetBasePath(Directory.GetCurrentDirectory())
    //     .AddJsonFile("appsettings.json")
    //     .Build();

    //     var connectionString = configuration.GetConnectionString("AppDb");
    //     optionsBuilder.UseSqlServer(connectionString);
    // }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Guest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Guest__3214EC0791FC48AA");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<Visit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Visit__3214EC073FCD0F19");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
