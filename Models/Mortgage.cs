using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using finly.Enums;

namespace finly.Models
{
    public class Mortgage
    {
        [Key]
        public int Id { get; set; }

        public int ProfileId { get; set; }

        public Profile Profile { get; set; }

        public ICollection<MortgageClient> MortgageClients { get; set; } = new List<MortgageClient>();

        public int? CompanyClientId { get; set; }

        public CompanyClient CompanyClient { get; set; }
    }
}