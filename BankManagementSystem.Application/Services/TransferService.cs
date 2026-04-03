using BankManagementSystem.Application.DTOs;
using BankManagementSystem.Domain.Entities;
using BankManagementSystem.Domain.Interfaces;
using BankManagementSystem.Domain.Services;

namespace BankManagementSystem.Application.Services
{
    public class TransferService
    {
        private readonly ITransferRepository repository;
        private readonly TransferDomainService domainService;

        public TransferService(ITransferRepository repository)
        {
            this.repository = repository;
            this.domainService = new TransferDomainService();
        }

        public void CreateTransfer(CreateTransferDTO dto)
        {
            var transfer = new Transfer
            {
                SourceAccount = dto.SourceAccount,
                DestinationAccount = dto.DestinationAccount,
                Amount = dto.Amount
            };

            domainService.CreateTransfer(transfer);

            repository.Save(transfer);
        }
    }
}