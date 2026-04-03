using BankManagementSystem.Domain.Entities;

namespace BankManagementSystem.Domain.Interfaces
{
    public interface IAccountRepository
    {
        void Save(BankAccount account); // <-- Cambiado a BankAccount
        BankAccount GetByUserId(Guid userId); // <-- Cambiado a BankAccount
        IEnumerable<BankAccount> GetAll(); // <-- Cambiado a BankAccount
        void Update(BankAccount account); // <-- Cambiado a BankAccount
    }
}