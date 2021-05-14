using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

public class DailyRentContext : DbContext
{
    public DbSet<Post> Posts { get; set; }
    public DbSet<Owner> Owners { get; set; }
    public DbSet<Apartment> Apartments { get; set; }
    public DbSet<Type> Types { get; set; }

    public DailyRentContext(DbContextOptions<DailyRentContext> options) : base(options) {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder); 
    }

}