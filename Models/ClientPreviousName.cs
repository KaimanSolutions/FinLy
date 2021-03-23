using System;
using System.ComponentModel.DataAnnotations;
using finly.Enums;

namespace finly.Models
{
    public class ClientPreviousName
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ClientId { get; set; }

        public Client Client { get; set; }

        public TitleTypes? Title { get; set; }

        [StringLength(255)]
        public string FirstName { get; set; }
        
        [StringLength(255)]
        public string MiddleName { get; set; }
        
        [StringLength(255)]
        public string LastName { get; set; }

        public DateTime? DateOfNameChange { get; set; }
    }
}