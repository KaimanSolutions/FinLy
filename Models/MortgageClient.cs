namespace finly.Models
{
    public class MortgageClient
    {
        public int MortgageId { get; set; }

        public Mortgage Mortgage { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }
    }
}