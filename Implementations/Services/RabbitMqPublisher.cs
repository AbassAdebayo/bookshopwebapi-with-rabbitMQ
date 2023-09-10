using System.Text;
using RabbitMQ.Client;

public class RabbitMqPublisher : IRabbitMqPublisher
{
   private readonly IConnection _connection;
    public RabbitMqPublisher(IConnection connection)
    {
        _connection = connection;
    }

    public void PublishMessage(string exchangeName, string routingKey, string message)
    {
        using (var channel = _connection.CreateModel())
        {
            channel.ExchangeDeclare(exchangeName, ExchangeType.Direct, durable: true, autoDelete: false);

            var body = Encoding.UTF8.GetBytes(message);

            channel.BasicPublish(exchange: exchangeName, routingKey: routingKey, basicProperties: null, body: body);
        }
    }
}

