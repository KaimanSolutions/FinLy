using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace finly.Models
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string DisplayName { get; set; }
        
        [Required]
        public DateTime CreateDate { get; set; }

        public ICollection<Client> Clients { get; set; } = new List<Client>();

        public ICollection<CompanyClient> CompanyClients { get; set; } = new List<CompanyClient>();

        public ICollection<Mortgage> Mortgages { get; set; } = new List<Mortgage>();
    }
}