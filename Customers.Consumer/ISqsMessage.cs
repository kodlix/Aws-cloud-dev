using Mediator.Net.Contracts;
using MediatR;

namespace Customers.Consumer;

public interface ISqsMessage: IRequest<Unit>
{
    
}