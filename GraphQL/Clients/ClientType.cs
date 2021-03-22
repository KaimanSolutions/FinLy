using System.Linq;
using finly.Data;
using finly.Models;
using HotChocolate;
using HotChocolate.Types;

namespace finly.GraphQL.Clients
{
    public class ClientType : ObjectType<Client>
    {
        protected override void Configure(IObjectTypeDescriptor<Client> descriptor)
        {
             // Adding description of type object for documentation
            descriptor.Description("Represents the clients held within the profile.");

            descriptor
                .Field(c => c.Profile)
                .ResolveWith<Resolvers>(c => c.GetProfile(default!, default))
                .UseDbContext<AppDbContext>()
                .Description("The profile that holds their clients and their applications.");
        }

        private class Resolvers
        {
            public Profile GetProfile(Client client, [ScopedService] AppDbContext context)
            {
                return context.Profiles.FirstOrDefault(p => p.Id == client.ProfileId);
            }
        }
    }
}