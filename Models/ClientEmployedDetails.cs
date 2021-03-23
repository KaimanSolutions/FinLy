using System;
using System.ComponentModel.DataAnnotations;
using finly.Enums;

namespace finly.Models
{
    public class ClientEmployedDetails
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ClientId { get; set; }

        public Client Client { get; set; }

        [Required]
        public EmploymentCategoryTypes EmploymentCategory { get; set; }

        [StringLength(255)]
        public string Occupation { get; set; }

        [StringLength(255)]
        public string Employer { get; set; }

        public EmployedSubTypes? EmploymentSubType { get; set; }

        public EmployedFullTimeTypes? EmployedFullTime { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [StringLength(100)]
        public string EmployeeReference { get; set; }

        public bool InProbationPeriod { get; set; }

        public DateTime? ProbationPeriodEnd { get; set; }

        [StringLength(255)]
        public string NatureOfBusiness { get; set; }

        public bool OwnShares { get; set; }

        public int SharesOwned { get; set; }
    }
}