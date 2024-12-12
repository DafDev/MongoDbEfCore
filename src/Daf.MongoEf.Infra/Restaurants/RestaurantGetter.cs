using Daf.MongoEf.Domain.Models;
using Daf.MongoEf.Domain.Store.Restaurants;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Bson;

namespace Daf.MongoEf.Infra.Restaurants;

public class RestaurantGetter(IOptionsMonitor<RestaurantReservationDbContext> dbContext) : IGetRestaurants
{
    public Restaurant? GetRestaurantById(ObjectId id) => dbContext.CurrentValue.Restaurants.Find(id);

    public Restaurant? GetRestaurantByName(string name) => dbContext.CurrentValue.Restaurants
        .FirstOrDefault(restaurant => restaurant.Name == name);

    public IEnumerable<Restaurant>? GetAll() => dbContext.CurrentValue.Restaurants
        .OrderByDescending(restaurant => restaurant.Id)
        .Take(20)
        .AsNoTracking(); //ToDo implement pagination
}