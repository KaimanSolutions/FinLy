namespace finly.GraphQL.Clients
{
    public record AddClientInput(string FirstName, string MiddleName, string LastName, string Email, int ProfileId);
}