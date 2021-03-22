using finly.Models;
using HotChocolate;
using HotChocolate.Types;

namespace finly.GraphQL
{
    public class Subscription
    {
        //Subscription Endpoint
        [Subscribe]
        [Topic]
        public Profile OnProfileAdded([EventMessage] Profile profile)
        {
            return profile;
        }

        [Subscribe]
        [Topic]
        public Client OnClientAdded([EventMessage] Client client)
        {
            return client;
        }
    }
}