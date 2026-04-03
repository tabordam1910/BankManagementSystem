using System;
using System.Collections.Generic;
using System.Linq;
using BankManagementSystem.Application.DTOs;
using BankManagementSystem.Domain.Entities;

namespace BankManagementSystem.Application.Services
{
    public class AccountService
    {
        // Lista estática para que los datos persistan mientras la app esté abierta
        private static List<BankAccount> _accounts = new List<BankAccount>();

        // 1. CREAR CUENTA (Este soluciona el error en UserService.cs)
        public BankAccount CreateAccount(Guid userId)
        {
            var newAccount = new BankAccount
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                Balance = 0
            };

            _accounts.Add(newAccount);
            return newAccount;
        }

        // 2. DEPOSITAR
        public TransactionResponse Deposit(Guid userId, decimal amount)
        {
            var account = _accounts.FirstOrDefault(a => a.UserId == userId);

            if (account == null)
                return new TransactionResponse { Message = "Cuenta no encontrada." };

            if (amount <= 0)
                return new TransactionResponse { Message = "El monto debe ser mayor a cero." };

            account.Balance += amount;

            return new TransactionResponse
            {
                Message = "Depósito exitoso.",
                Balance = account.Balance
            };
        }

        // 3. RETIRAR
        public TransactionResponse Withdraw(Guid userId, decimal amount)
        {
            var account = _accounts.FirstOrDefault(a => a.UserId == userId);

            if (account == null)
                return new TransactionResponse { Message = "Cuenta no encontrada." };

            if (amount <= 0)
                return new TransactionResponse { Message = "Monto inválido." };

            if (account.Balance < amount)
                return new TransactionResponse { Message = "Saldo insuficiente." };

            account.Balance -= amount;

            return new TransactionResponse
            {
                Message = "Retiro exitoso.",
                Balance = account.Balance
            };
        }

        // 4. TRANSFERIR
        public TransactionResponse Transfer(Guid fromUserId, Guid toUserId, decimal amount)
        {
            var sourceAccount = _accounts.FirstOrDefault(a => a.UserId == fromUserId);
            var destinationAccount = _accounts.FirstOrDefault(a => a.UserId == toUserId);

            if (sourceAccount == null || destinationAccount == null)
                return new TransactionResponse { Message = "Una de las cuentas no existe." };

            if (amount <= 0)
                return new TransactionResponse { Message = "El monto debe ser mayor a cero." };

            if (sourceAccount.Balance < amount)
                return new TransactionResponse { Message = "Saldo insuficiente para transferir." };

            // El movimiento de dinero
            sourceAccount.Balance -= amount;
            destinationAccount.Balance += amount;

            return new TransactionResponse
            {
                Message = "Transferencia realizada con éxito.",
                Balance = sourceAccount.Balance
            };
        }
    }
}