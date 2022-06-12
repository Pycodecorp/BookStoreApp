using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace BookStoreAppApi.Models
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Name")]
        [JsonProperty("Name")]
        public string Name { get; set; } = null!;

        [BsonElement("Price")]
        [JsonProperty("Price")]
        public decimal Price { get; set; }

        [BsonElement("Category")]
        [JsonProperty("Category")]
        public string Category { get; set; } = null!;

        [BsonElement("Author")]
        [JsonProperty("Author")]
        public string Author { get; set; } = null!;
    }
}
