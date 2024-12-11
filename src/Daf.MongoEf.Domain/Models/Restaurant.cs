using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.EntityFrameworkCore;

namespace Daf.MongoEf.Domain.Models;

[Collection("restaurants")]  
public class Restaurant
{
    public ObjectId Id { get; set; }

    [Required(ErrorMessage = "You must provide a name")]
    [BsonElement("name")]
    public string Name { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "You must add a cuisine type")]
    [BsonElement("cuisine")]
    public string Cuisine { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "You must add the borough of the restaurant")]
    [BsonElement("borough")]
    public string Borough { get; set; } = string.Empty;
}