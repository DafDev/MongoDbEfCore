using Daf.MongoEf.Domain.Models;
using MongoDB.Bson;

namespace Daf.MongoEf.Domain.Store.Reservations;

public interface IDeleteReservations
{
    bool DeleteReservations(IEnumerable<ObjectId> reservationIds);
    bool DeleteReservation(ObjectId reservationId);
}