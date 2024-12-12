using Daf.MongoEf.Domain.Models;
using MongoDB.Bson;

namespace Daf.MongoEf.Domain.Store.Reservations;

public interface IGetRestaurantReservations
{
    Reservation? GetById(ObjectId id);
    IEnumerable<Reservation>? GetByCustomerAndDate(ObjectId id, DateTimeOffset date);
    IEnumerable<Reservation> GetAll();
}