using System.ComponentModel.DataAnnotations;
using finly.Enums;

namespace finly.Models 
{
    public class ClientOtherIncome
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ClientId { get; set; }

        public Client Client { get; set; }

        public OtherIncomeTypes OtherIncomeType { get; set; }

        public decimal GrossAnnualAmount { get; set; }

        public decimal NetMonthlyAmount { get; set; }

    }
}