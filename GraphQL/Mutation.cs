using System;
using System.Threading.Tasks;
using finly.Data;
using finly.GraphQL.Clients;
using finly.GraphQL.Profiles;
using finly.Models;
using HotChocolate;
using HotChocolate.Data;

namespace finly.GraphQL
{
    
    public class Mutation
    {
        [UseDbContext(typeof(AppDbContext))]
        public async Task<AddProfilePayload> AddProfileAsync(AddProfileInput input,
            [ScopedService] AppDbContext context)
            {
                var profile = new Profile {
                    DisplayName = input.DisplayName,
                    CreateDate = DateTime.Now
                };

                context.Profiles.Add(profile);
                await context.SaveChangesAsync();

                return new AddProfilePayload(profile);
            }

        [UseDbContext(typeof(AppDbContext))]
        public async Task<AddClientPayload> AddClientAsync(AddClientInput input,
            [ScopedService] AppDbContext context)
            {
                var client = new Client {
                    FirstName = input.FirstName,
                    MiddleName = input.MiddleName,
                    LastName = input.LastName,
                    Email = input.Email,
                    ProfileId = input.ProfileId
                };

                context.Clients.Add(client);
                await context.SaveChangesAsync();

                return new AddClientPayload(client);
            }
    }
}