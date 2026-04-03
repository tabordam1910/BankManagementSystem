using BankManagementSystem.Domain.Enums;

namespace BankManagementSystem.Domain.Entities
{
    public class Transfer
    {
        public int Id { get; set; }

        public string SourceAccount { get; set; } = string.Empty;
        public string DestinationAccount { get; set; } = string.Empty;

        public decimal Amount { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? ApprovedAt { get; set; }

        public TransferStatus Status { get; set; }

        public int CreatedByUserId { get; set; }
        public int? ApprovedByUserId { get; set; }
    }
}