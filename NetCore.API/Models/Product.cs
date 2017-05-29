using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NetCore.API.Models
{
    public class Product
    {
        public ObjectId Id { get; set; }
        [BsonElement("ProductId")]
        public int ProductId { get; set; }
        [BsonElement("ProductName")]
        public string ProductName3 { get; set; }
        [BsonElement("Price")]
        public int Price { get; set; }
        [BsonElement("Price2")]
        public int Price2 { get; set; }
        [BsonElement("Price3")]
        public int Price3 { get; set; }
        [BsonElement("Category")]
        public string Category { get; set; }
        [BsonElement("IsMainCategory")]
        public bool IsMainCategory { get; set; }
    }

}