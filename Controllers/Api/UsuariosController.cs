using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

[ApiController]
[Route("api/usuarios")]

public class UsuariosController : ControllerBase
{










    [HttpGet]
    public IActionResult ListarUsuarios()
    {
        return Ok();
    }
}