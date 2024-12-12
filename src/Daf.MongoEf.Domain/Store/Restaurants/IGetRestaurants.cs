using Daf.MongoEf.Domain.Models;
using MongoDB.Bson;

namespace Daf.MongoEf.Domain.Store.Restaurants;

public interface IGetRestaurants
{
    Restaurant? GetRestaurantById(ObjectId id);
    Restaurant? GetRestaurantByName(string name);
    IEnumerable<Restaurant>? GetAll();
}
