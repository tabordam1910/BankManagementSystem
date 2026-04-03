using BankManagementSystem.Application.DTOs;
using BankManagementSystem.Domain.Entities;
using BankManagementSystem.Domain.Interfaces;
using BankManagementSystem.Domain.Services;

namespace BankManagementSystem.Application.UseCases
{
    public class CreateTransferUseCase
    {
        private readonly ITransferRepository repository;
        private readonly TransferDomainService domainService;

        public CreateTransferUseCase(ITransferRepository repository)
        {
            this.repository = repository;
            this.domainService = new TransferDomainService();
        }

        public void Execute(CreateTransferDTO dto)
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