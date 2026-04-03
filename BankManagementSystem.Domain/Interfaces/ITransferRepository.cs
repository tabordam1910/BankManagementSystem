using BankManagementSystem.Domain.Entities;
using BankManagementSystem.Domain.Interfaces;
using System.Collections.Generic;

namespace BankManagementSystem.Domain.Interfaces
{
    public interface ITransferRepository
    {
        void Save(Transfer transfer);

        List<Transfer> GetAll();

        Transfer? GetById(int id);
    }
}