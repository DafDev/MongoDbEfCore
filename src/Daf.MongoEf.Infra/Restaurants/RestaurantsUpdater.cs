using Daf.MongoEf.Domain.Models;
using Daf.MongoEf.Domain.Store.Restaurants;
using Microsoft.Extensions.Options;

namespace Daf.MongoEf.Infra.Restaurants;

public class RestaurantsUpdater(IOptionsMonitor<RestaurantReservationDbContext> dbContext,
    IGetRestaurants restaurantGetter) : ICreateOrUpdateRestaurants
{
    public void AddRestaurant(Restaurant restaurant)
    {
        dbContext.CurrentValue.Restaurants.Add(restaurant);
        dbContext.CurrentValue.SaveChanges();
    }

    public Restaurant UpdateRestaurant(Restaurant restaurant)
    {
        var restaurantToUpdate = restaurantGetter.GetRestaurantById(restaurant.Id);
        ArgumentNullException.ThrowIfNull(restaurantToUpdate);
        
        restaurantToUpdate.Name = restaurant.Name;
        restaurantToUpdate.Borough = restaurant.Borough;
        restaurantToUpdate.Cuisine = restaurant.Cuisine;
        
        dbContext.CurrentValue.Restaurants.Update(restaurantToUpdate);
        return restaurantToUpdate;
    }
}