using Daf.MongoEf.Domain.Models;

namespace Daf.MongoEf.Domain.Store;

public interface IGetCustomer
{
    public Customer? GetCustomer(int customerId);
    public IEnumerable<Customer> GetAll();
}