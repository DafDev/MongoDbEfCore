using Daf.MongoEf.Infra.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddDbContext(builder.Configuration)
    .AddInfra();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
