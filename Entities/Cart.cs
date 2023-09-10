public class Cart: BaseEntity
{
    public int UserId { get; set; }
    public List<CartItem> CartItems { get; set; } = new List<CartItem>();
}