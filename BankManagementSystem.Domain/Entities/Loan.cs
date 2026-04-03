using BankManagementSystem.Domain.Enums;

namespace BankManagementSystem.Domain.Entities
{
    public class Loan
    {
        public int Id { get; set; }

        public string ClientId { get; set; } = string.Empty;

        public decimal RequestedAmount { get; set; }
        public decimal ApprovedAmount { get; set; }

        public LoanStatus Status { get; set; }

        public string DestinationAccount { get; set; } = string.Empty;
    }
}