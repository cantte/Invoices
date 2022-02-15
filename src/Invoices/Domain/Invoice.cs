using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Invoices.Domain;

public class Invoice
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string Customer { get; set; }
    public string City { get; set; }
    public string Nit { get; set; }

    public decimal Total { get; set; }
    public decimal Subtotal { get; set; }
    public decimal Iva { get; set; }
    public decimal Retention { get; set; }

    public DateTime CreatedAt { get; set; }

    public string State { get; set; }

    public bool Paid { get; set; }
    public DateTime? PaidAt { get; set; }
}