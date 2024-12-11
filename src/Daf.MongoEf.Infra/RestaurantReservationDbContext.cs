using Daf.MongoEf.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Daf.MongoEf.Infra;

public class RestaurantReservationDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Restaurant> Restaurants { get; init; }
    
    public DbSet<Reservation> Reservations { get; init; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Restaurant>();
        modelBuilder.Entity<Reservation>();
    }
}