// See https://aka.ms/new-console-template for more information


using System.Text.Json;
using Amazon.SQS;
using Amazon.SQS.Model;
using sqspublisher.DTO;

var sqsClient = new AmazonSQSClient();

var customer = new CustomerCreatedDto()
{
    Id = Guid.NewGuid(),
    Email = "chikajohnson@gmail.com",
    FullName = "Johnson Iyida",
    GithHubUserName = "kodlix",
    DateOfBirth = new DateTime(1990, 2, 12)
};

var queueUelResponse = await sqsClient.GetQueueUrlAsync("customers");
var sendMessageRequest = new SendMessageRequest()
{
    QueueUrl = queueUelResponse.QueueUrl,
    MessageBody = JsonSerializer.Serialize(customer),
    MessageAttributes = new Dictionary<string, MessageAttributeValue>()
    {
        {
            "MessageType", new MessageAttributeValue()
            {
                DataType = "String",
                StringValue = nameof(CustomerCreatedDto),
            }
        }
    }
};
 
 var response = await sqsClient.SendMessageAsync(sendMessageRequest);
 Console.Write(response);