using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

var factory = new ConnectionFactory() {Uri = new Uri("amqps://ukevpojv:M0HW5QbuwlpT2iiprOCzcgBYxPZUxmFC@hummingbird.rmq.cloudamqp.com/ukevpojv") };

using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.ExchangeDeclare("my_direct_exchange", ExchangeType.Direct);
var queueName = channel.QueueDeclare().QueueName;

channel.QueueBind(queueName, "my_direct_exchange","logs");

var consumer = new EventingBasicConsumer(channel);

consumer.Received += (sender, eventArgs) =>
{
    var message = Encoding.UTF8.GetString(eventArgs.Body.ToArray());
    Console.WriteLine(message);
};

channel.BasicConsume(queueName, false, consumer);

Console.ReadKey();