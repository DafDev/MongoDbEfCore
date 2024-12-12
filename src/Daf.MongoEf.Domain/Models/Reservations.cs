using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.EntityFrameworkCore;

namespace Daf.MongoEf.Domain.Models;

[Collection("reservations")]
public class Reservation
{
    public ObjectId Id { get; set; }
    
    [BsonElement("restaurant_id")]
    public ObjectId RestaurantId { get; set; }
    
    [BsonElement("customer_id")]
    public ObjectId CustomerId { get; set; }

    [BsonElement("restaurant_name")]
    public string RestaurantName { get; set; } = string.Empty;

    [Required(ErrorMessage = "The date and time is required to make this reservation")]
    [BsonElement("date")]
    public DateTimeOffset Date { get; set; }

}