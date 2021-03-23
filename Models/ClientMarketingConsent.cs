using System;
using System.ComponentModel.DataAnnotations;
using finly.Enums;

namespace finly.Models
{
    public class ClientMarketingConsent
    {
        [Key]
        public int Id { get; set; }

        public MarketingConsentTypes ConsentType { get; set; }

        public DateTime? ConsentGivenDate { get; set; }

        public bool ClientConsentedDirectly { get; set; }

        public string HowWasConsentObtained { get; set; }

        public DateTime? ConsentRetractedDate { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }
    }
}