
public class OrderRepository : IOrderRepository
{
    private readonly BookshopContext _bookshopContext;

    public OrderRepository(BookshopContext bookshopContext)
    {
        _bookshopContext = bookshopContext;
    }

    public async Task<Order> CreateOrder(Order order)
    {
        await _bookshopContext.Orders.AddAsync(order);
        await _bookshopContext.SaveChangesAsync();
        return order;
    }

    public Task<IEnumerable<Order>> GetAllOrders()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Order>> GetOrdersByUserId(Guid userId)
    {
        throw new NotImplementedException();
    }
}
