using Daf.MongoEf.Domain.Models;
namespace Daf.MongoEf.Domain.Store.Restaurants;

public interface ICreateOrUpdateRestaurants
{
    void AddRestaurant(Restaurant restaurant);
    Restaurant UpdateRestaurant(Restaurant restaurant);
}