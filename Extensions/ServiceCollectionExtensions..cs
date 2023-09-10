using Microsoft.EntityFrameworkCore;
using RabbitMQ.Client;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        return services
        
        .AddScoped<IBookRepository, BookRepository>()
        .AddScoped<IOrderRepository, OrderRepository>()
        .AddScoped<IUserRepository, UserRepository>();
    
                        
    }

    public static IServiceCollection AddDatabase(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<BookshopContext>(options =>
            options.UseMySQL(connectionString));

        return services;
    }

  

// ...

public static IServiceCollection RabbitMQServices(this IServiceCollection services)
{
    

// Create a Configuration object
    IConfiguration configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json") 
    .Build();
    var factory = new ConnectionFactory
    {
        HostName = configuration["RabbitMQ:HostName"],
        UserName = configuration["RabbitMQ:UserName"],
        Password = configuration["RabbitMQ:Password"],
        Port = int.Parse(configuration["RabbitMQ:Port"])
    };

    services.AddSingleton(factory);
    services.AddSingleton<IConnection>(sp => sp.GetRequiredService<ConnectionFactory>().CreateConnection());
    services.AddSingleton<ITopicPublisher, RabbitMqPublisher>();
}




}