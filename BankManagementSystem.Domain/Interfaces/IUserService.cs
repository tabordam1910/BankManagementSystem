using BankManagementSystem.Domain.Entities;

namespace BankManagementSystem.Domain.Interfaces
{
    public interface IUserService
    {
        User CreateUser(string name, string email);
        User GetUserById(Guid id);
    }
}