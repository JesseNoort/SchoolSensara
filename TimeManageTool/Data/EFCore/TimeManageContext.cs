

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
        modelBuilder.Entity<Customer>()
            .HasMany(e => e.Activities)
            .WithOne(e => e.Customer)
            .HasForeignKey(e => e.CustomerId)
            .HasPrincipalKey(e => e.Id);
        modelBuilder.Entity<Location>()        
            .HasMany(e => e.Customers)
            .WithOne(e => e.Location)
            .HasForeignKey(e => e.LocationId)
            .HasPrincipalKey(e => e.Id);
        modelBuilder.Entity<Organisation>()
            .HasMany(e => e.Locations)
            .WithOne(e => e.Organisation)
            .HasForeignKey(e => e.OrganisationId)
            .HasPrincipalKey(e => e.Id);
        modelBuilder.Entity<Product>()
            .HasMany(e => e.Products)
            .WithOne(e => e.Product)
            .HasForeignKey(e => e.ProductId)
            .HasPrincipalKey(e => e.Id);
        modelBuilder.Entity<User>()
            .HasMany(e => e.Activities)
            .WithOne(e => e.User)
            .HasForeignKey(e => e.UserId)
            .HasPrincipalKey(e => e.Id);
        modelBuilder.Entity<Time>().ToTable("Time");
        modelBuilder.Entity<Activity>().ToTable("Activity");
        modelBuilder.Entity<ProductUsed>().ToTable("ProductUsed");
    }

}