using Daf.MongoEf.Domain.Store.Restaurants;
using Microsoft.Extensions.Options;
using MongoDB.Bson;

namespace Daf.MongoEf.Infra.Restaurants;

public class RestaurantDeleter(IOptionsMonitor<RestaurantReservationDbContext> dbContext, 
    IGetRestaurants restaurantGetter) : IDeleteRestaurants
{
    public void DeleteRestaurant(ObjectId id)
    {
        var restaurantToDelete = restaurantGetter.GetRestaurantById(id);
        ArgumentNullException.ThrowIfNull(restaurantToDelete);
        dbContext.CurrentValue.Restaurants.Remove(restaurantToDelete);
        dbContext.CurrentValue.SaveChanges();
    }

    public void DeleteRestaurants(IEnumerable<ObjectId> ids)
    {
        throw new NotImplementedException();
    }
}