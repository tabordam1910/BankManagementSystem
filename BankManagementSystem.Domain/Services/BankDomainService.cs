using BankManagementSystem.Domain.Entities;

namespace BankManagementSystem.Domain.Services
{
    public class BankDomainService
    {
        // Esta es la lógica pura de tu banco
        public bool IsTransferValid(BankAccount source, decimal amount)
        {
            // Verificamos que la cuenta exista, tenga saldo y el monto sea real
            return source != null && source.Balance >= amount && amount > 0;
        }
    }
}