using System;

namespace BankManagementSystem.Domain.Entities
{
    public class BankAccount
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; } // Asegúrate de que diga UserId con 'U' e 'I' mayúsculas
        public decimal Balance { get; set; }
    }
}