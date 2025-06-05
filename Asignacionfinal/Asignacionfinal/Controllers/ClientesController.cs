using Asignacionfinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asignacionfinal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private static List<Cliente> clientes = new List<Cliente>
    {
        new Cliente { Id = 1, Nombre = "Ana", Edad = 25 },
        new Cliente { Id = 2, Nombre = "Luis", Edad = 30 },
        new Cliente { Id = 3, Nombre = "Carlos", Edad = 28 }
    };

        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get() => clientes;
    }
}
