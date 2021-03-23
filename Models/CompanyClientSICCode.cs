using System.ComponentModel.DataAnnotations;
using finly.Enums;

namespace finly.Models
{
    public class CompanyClientSICCode
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CompanyClientId { get; set; }
        
        public CompanyClient CompanyClient { get; set; }

        [StringLength(10)]
        public string SICCode { get; set; }
    }
}