using System.Linq;
using finly.Data;
using finly.Models;
using HotChocolate;
using HotChocolate.Types;

namespace finly.GraphQL.Profiles
{
    public class ProfileType : ObjectType<Profile>
    {
        protected override void Configure(IObjectTypeDescriptor<Profile> descriptor)
        {
            // Adding description of type object for documentation
            descriptor.Description("Represents the file holding the clients and any of their applications, such as mortgages, loans and insurance policies");

            // Removing Profile.CreateDate from schema as do not want this exposed via API
            descriptor
                .Field(p => p.CreateDate).Ignore()
                .Description("The date this profile was added to the system");

            descriptor
                .Field(p => p.DisplayName)
                .Description("Reference number for overall profile, visible within the platform.");

            descriptor
                .Field(p => p.Clients)
                .ResolveWith<Resolvers>(p => p.GetClients(default!, default))
                .UseDbContext<AppDbContext>()
                .Description("The list of clients attached to the this profile.");
        }


        // Resolves how to link Clients to Profiles.
        private class Resolvers
        {
            public IQueryable<Client> GetClients(Profile profile, [ScopedService] AppDbContext context)
            {
                // Only return clients that are within the Profile
                return context.Clients.Where(p => p.ProfileId == profile.Id);
            }
        }
    }
}