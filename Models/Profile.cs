using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HotChocolate;

namespace finly.Models
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [GraphQLDescription("Reference number for overall profile, visible within the platform.")]
        public string DisplayName { get; set; }
        
        [Required]
        [GraphQLDescription("Date the profile was created when added to the system.")]
        public DateTime CreateDate { get; set; }

        public ICollection<Client> Clients { get; set; } = new List<Client>();
    }
}