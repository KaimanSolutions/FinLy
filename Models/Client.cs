using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using finly.Enums;

namespace finly.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }
    
        [StringLength(255)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        public int ProfileId { get; set; }

        public Profile Profile { get; set; }

        [StringLength(50)]
        public TitleTypes? Title { get; set; }

        [StringLength(255)]
        public string PreferredName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public GenderTypes? Gender { get; set; }

        public SmokerStatusTypes? SmokerStatus { get; set; }

        public DateTime? SmokingQuitDate { get; set; }

        [StringLength(25)]
        public string NationalInsuranceNumber { get; set; }

        public ICollection<ClientPreviousName> PreviousNames { get; set; } = new List<ClientPreviousName>();

        public ICollection<ClientMarketingConsent> ClientMarketingConsents { get; set; } = new List<ClientMarketingConsent>();

        public ICollection<MortgageClient> MortgageClients { get; set; } = new List<MortgageClient>();
    }
}