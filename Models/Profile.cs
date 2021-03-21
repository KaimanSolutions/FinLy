using System;
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
    }
}