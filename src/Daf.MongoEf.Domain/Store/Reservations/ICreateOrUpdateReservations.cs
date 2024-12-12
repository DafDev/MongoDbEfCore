using Daf.MongoEf.Domain.Models;

namespace Daf.MongoEf.Domain.Store;

public interface ICreateOrUpdateReservations
{
    void CreateOrUpdateReservations(IEnumerable<Reservation> reservations);
    void AddReservation(Reservation reservation);
    void UpdateReservation(Reservation reservation);
}