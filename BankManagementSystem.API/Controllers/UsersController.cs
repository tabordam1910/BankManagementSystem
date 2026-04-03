using Microsoft.AspNetCore.Mvc;
using BankManagementSystem.Application.Services;
using System;

namespace BankManagementSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        // 1. OBTENER USUARIO POR ID
        [HttpGet("{id}")]
        public IActionResult GetUser(Guid id)
        {
            // Buscamos el usuario a través del servicio
            var user = _userService.GetUserById(id);

            if (user == null)
            {
                return NotFound(new { message = "Usuario no encontrado." });
            }

            return Ok(user);
        }

        // 2. CREAR USUARIO (Y SU CUENTA)
        [HttpPost]
        public IActionResult CreateUser(string name, string email)
        {
            try
            {
                // El servicio devuelve un UserResponse (que definimos antes)
                var response = _userService.CreateUser(name, email);

                // Devolvemos el objeto creado
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Error al crear el usuario.", error = ex.Message });
            }
        }
    }
}