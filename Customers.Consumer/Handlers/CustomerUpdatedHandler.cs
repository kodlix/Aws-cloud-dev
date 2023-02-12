using Customers.Consumer.Messages;
using MediatR;

namespace Customers.Consumer.Handlers;

public class CustomerUpdatedHandler : IRequestHandler<CustomerDeleted>
{
    private readonly ILogger<CustomerCreatedHandler> _logger;

    public CustomerUpdatedHandler(ILogger<CustomerCreatedHandler> logger)
    {
        _logger = logger;
    }

    public Task<Unit> Handle(CustomerDeleted request, CancellationToken cancellationToken)
    {
        _logger.LogInformation(request.Id.ToString());
        return Unit.Task;
    }
}