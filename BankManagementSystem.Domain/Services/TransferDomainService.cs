using BankManagementSystem.Domain.Entities;
using BankManagementSystem.Domain.Enums;

namespace BankManagementSystem.Domain.Services
{
    public class TransferDomainService
    {
        private const decimal APPROVAL_LIMIT = 10000;

        public void CreateTransfer(Transfer transfer)
        {
            if (transfer.Amount <= 0)
                throw new Exception("Amount must be greater than zero");

            if (transfer.Amount > APPROVAL_LIMIT)
            {
                transfer.Status = TransferStatus.PendingApproval;
            }
            else
            {
                transfer.Status = TransferStatus.Executed;
            }

            transfer.CreatedAt = DateTime.UtcNow;
        }

        public void ApproveTransfer(Transfer transfer)
        {
            if (transfer.Status != TransferStatus.PendingApproval)
                throw new Exception("Transfer is not pending approval");

            transfer.Status = TransferStatus.Executed;
            transfer.ApprovedAt = DateTime.UtcNow;
        }

        public void RejectTransfer(Transfer transfer)
        {
            transfer.Status = TransferStatus.Rejected;
        }
    }
}