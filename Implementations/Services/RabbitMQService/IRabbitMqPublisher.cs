public interface IRabbitMqPublisher
{
    void PublishMessage(string exchangeName, string routingKey, string message);
}