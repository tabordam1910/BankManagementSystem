using BankManagementSystem.Domain.Entities;
using System.Collections.Generic;

namespace BankManagementSystem.Infrastructure.Persistence
{
    public static class InMemoryDatabase
    {
        public static List<Transfer> Transfers { get; set; } = new List<Transfer>();

        public static List<BankAccount> Accounts { get; set; } = new List<BankAccount>();

        public static List<User> Users { get; set; } = new List<User>();

        public static List<Loan> Loans { get; set; } = new List<Loan>();
    }
}