

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TimeManageTool.Models;

namespace TimeManageTool.Data;

public class TimeManageContext:DbContext
{
     public TimeManageContext(DbContextOptions<TimeManageContext> options) : base(options)
     {
    }
     
    public DbSet<Activity> Activities { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Organisation> Organisations { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Time> Times { get; set; }
    public DbSet<ProductUsed> ProductUseds { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().ToTable("Customer");
        modelBuilder.Entity<Location>().ToTable("Location");
        modelBuilder.Entity<Organisation>().ToTable("Organisation");
        modelBuilder.Entity<Product>().ToTable("Product");
        modelBuilder.Entity<User>().ToTable("User");
        modelBuilder.Entity<Time>().ToTable("Time");
        modelBuilder.Entity<Activity>().ToTable("Activity");
        modelBuilder.Entity<ProductUsed>().ToTable("ProductUsed");
    }

}