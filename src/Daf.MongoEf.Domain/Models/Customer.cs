using MongoDB.Bson;

namespace Daf.MongoEf.Domain.Models;

public class Customer
{
    public ObjectId Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Order { get; set; } = string.Empty;
}