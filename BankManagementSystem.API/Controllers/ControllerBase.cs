using System; // Para Guid u otros tipos
using Microsoft.AspNetCore.Mvc;

namespace BankManagementSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExampleController : ControllerBase
    {
        // Constructor vacío si no necesitas servicios inyectados
        public ExampleController()
        {
        }

        [HttpGet("{id}")]
        public IActionResult GetExample(Guid id)
        {
            // Devuelve un ejemplo simple
            return Ok(new { Id = id, Message = "ControllerBase funciona perfectamente" });
        }
    }
}