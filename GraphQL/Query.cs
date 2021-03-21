using System.Linq;
using finly.Data;
using finly.Models;
using HotChocolate;
using HotChocolate.Data;

namespace finly.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        public IQueryable<Profile> GetProfile([ScopedService] AppDbContext context)
        {
            return context.Profiles;
        }
    }
}