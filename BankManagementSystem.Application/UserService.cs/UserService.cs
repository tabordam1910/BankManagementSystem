using System;
using System.Collections.Generic;
using System.Linq;
using BankManagementSystem.Domain.Entities;

namespace BankManagementSystem.Application.Services
{
    // Esta es la clase que devuelve el usuario y su cuenta al mismo tiempo
    public class UserResponse
    {
        public UserFake User { get; set; } = new();
        public BankAccount Account { get; set; } = new();
    }

    // Esta es la clase del usuario (puedes moverla a Domain/Entities después)
    public class UserFake
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }

    public class UserService
    {
        // Lista en memoria para simular la base de datos de usuarios
        private static List<UserFake> _users = new List<UserFake>();
        private readonly AccountService _accountService;

        public UserService(AccountService accountService)
        {
            _accountService = accountService;
        }

        // 1. OBTENER USUARIO (Esto arregla el error en el Controller)
        public UserFake? GetUserById(Guid id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        // 2. CREAR USUARIO Y CUENTA
        public UserResponse CreateUser(string name, string email)
        {
            var newUser = new UserFake
            {
                Id = Guid.NewGuid(),
                Name = name,
                Email = email
            };

            _users.Add(newUser);

            // Llamamos al AccountService para crear la cuenta bancaria vinculada
            var account = _accountService.CreateAccount(newUser.Id);

            return new UserResponse
            {
                User = newUser,
                Account = account
            };
        }
    }
}