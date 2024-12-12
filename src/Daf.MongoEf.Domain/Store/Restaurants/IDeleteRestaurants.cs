using MongoDB.Bson;

namespace Daf.MongoEf.Domain.Store.Restaurants;

public interface IDeleteRestaurants
{
    void DeleteRestaurant(ObjectId id);
    void DeleteRestaurants(IEnumerable<ObjectId> ids);
}