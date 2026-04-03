namespace BankManagementSystem.Application.DTOs
{
    public class CreateTransferDTO
    {
        public string SourceAccount { get; set; } = string.Empty;
        public string DestinationAccount { get; set; } = string.Empty;
        public decimal Amount { get; set; }
    }
}