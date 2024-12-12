using Microsoft.Extensions.Options;

namespace Daf.MongoEf.Infra;

public class MongoConnector(IOptionsMonitor<MongoDbSettings> settings) : IConnectToMongo
{
    public void Configure()
    {
        
    }
}