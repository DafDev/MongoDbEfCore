using Daf.MongoEf.Domain.Models;
using MongoDB.Bson;

namespace Daf.MongoEf.Domain.Store;

public interface IGetCustomer
{
    public Customer? GetCustomer(ObjectId customerId);
    public IEnumerable<Customer> GetAll();
}