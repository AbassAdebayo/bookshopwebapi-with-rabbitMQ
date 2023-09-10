public interface IOrderRepository
{
    Task<IEnumerable<Order>> GetOrdersByUserId(Guid userId);
    public Task<IEnumerable<Order>> GetAllOrders();
    Task<Order> CreateOrder(Order order);
}