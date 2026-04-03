using BankManagementSystem.Domain.Entities;
using BankManagementSystem.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BankManagementSystem.Infrastructure.Repositories
{
    public class TransferRepository : ITransferRepository
    {
        private static List<Transfer> database = new List<Transfer>();

        public void Save(Transfer transfer)
        {
            transfer.Id = database.Count + 1;
            database.Add(transfer);
        }

        public List<Transfer> GetAll()
        {
            return database;
        }

        public Transfer? GetById(int id)
        {
            return database.FirstOrDefault(t => t.Id == id);
        }
    }
}