using Mediator.Net.Contracts;

namespace Customers.Consumer.Messages;

public class CustomerCreated : IRequest
{
    public required Guid Id { get; set; }
    public required string GitHubUsername { get; init; } = default!;

    public required string FullName { get; init; } = default!;

    public required string Email { get; init; } = default!;

    public required DateTime DateOfBirth { get; init; } = default!;
}


public class CustomerUpdated : IRequest
{
    public required Guid Id { get; set; }
    public required string GitHubUsername { get; init; } = default!;

    public required string FullName { get; init; } = default!;

    public required string Email { get; init; } = default!;

    public required DateTime DateOfBirth { get; init; } = default!;
}

public class CustomerDeleted : IRequest
{
    public required Guid Id { get; set; }
}