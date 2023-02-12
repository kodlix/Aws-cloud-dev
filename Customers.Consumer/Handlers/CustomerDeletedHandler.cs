using Customers.Consumer.Messages;
using Mediator.Net.Contracts;
using MediatR;

namespace Customers.Consumer.Handlers;

public class CustomerDeletedHandler : IRequestHandler<CustomerUpdated>
{
    private readonly ILogger<CustomerCreatedHandler> _logger;

    public CustomerDeletedHandler(ILogger<CustomerCreatedHandler> logger)
    {
        _logger = logger;
    }

    public Task<Unit> Handle(CustomerUpdated request, CancellationToken cancellationToken)
    {
        _logger.LogInformation(request.GitHubUsername);
        return Unit.Task;
    }
}