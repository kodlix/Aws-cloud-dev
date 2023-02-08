namespace SqsConsumer.DTO;

public class CustomerCreatedDto
{
    public required Guid Id{ get; set; }
    public required string FullName{ get; set; }
    public required string Email{ get; set; }
    public required string GithHubUserName{ get; set; }
    public required DateTime DateOfBirth{ get; set; }
}