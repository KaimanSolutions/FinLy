using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using finly.Enums;

namespace finly.Models
{
    public class CompanyClient
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string RegisteredCompanyName { get; set; }

        [StringLength(100)]
        public string CompanyNumber { get; set; }

        public DateTime? IncorporationDate { get; set; }

        public CompanyTypes? CompanyType { get; set; }

        [Required]
        public int ProfileId { get; set; }

        public Profile Profile { get; set; }

        public ICollection<CompanyClientSICCode> CompanyClientSICCodes { get; set; } = new List<CompanyClientSICCode>();

        public ICollection<Mortgage> Mortgages { get; set; } = new List<Mortgage>();
    }
}