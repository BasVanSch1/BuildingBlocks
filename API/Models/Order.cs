using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    [PrimaryKey(nameof(Id))]
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; } // e.g., "Pending", "Shipped", "Delivered"
        public DateTime OrderDate { get; set; }
        public DateTime? ShippedDate { get; set; } // Nullable in case the order hasn't been shipped yet
        public DateTime? DeliveredDate { get; set; } // Nullable in case the order hasn't been delivered yet

    }
}
