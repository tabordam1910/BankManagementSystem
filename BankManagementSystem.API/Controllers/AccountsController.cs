using Microsoft.AspNetCore.Mvc;
using BankManagementSystem.Application.Services;

namespace BankManagementSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly AccountService _accountService;

        // El constructor inyecta el servicio de cuentas que ya configuramos
        public AccountsController(AccountService accountService)
        {
            _accountService = accountService;
        }

        // 1. Endpoint para DEPOSITAR
        [HttpPost("deposit")]
        public IActionResult Deposit(Guid userId, decimal amount)
        {
            var result = _accountService.Deposit(userId, amount);
            return Ok(result);
        }

        // 2. Endpoint para RETIRAR
        [HttpPost("withdraw")]
        public IActionResult Withdraw(Guid userId, decimal amount)
        {
            var result = _accountService.Withdraw(userId, amount);
            return Ok(result);
        }

        // 3. FINAL: Endpoint para TRANSFERIR entre usuarios
        [HttpPost("transfer")]
        public IActionResult Transfer(Guid fromUserId, Guid toUserId, decimal amount)
        {
            var result = _accountService.Transfer(fromUserId, toUserId, amount);
            return Ok(result);
        }
    }
}