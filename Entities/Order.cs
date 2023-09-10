public class Order: BaseEntity
{
    public int BookId { get; set; }
    public int Quantity { get; set; }
    public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}