using Amazon.SQS;
using Customers.Api.Messaging;
using Customers.Consumer;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.Configure<QueueSettings>(builder.Configuration.GetSection(QueueSettings.Key));
builder.Services.AddSingleton<IAmazonSQS, AmazonSQSClient>();
builder.Services.AddHostedService<QueueConsumerService>();

app.MapGet("/", () => "Hello World!");

app.Run();