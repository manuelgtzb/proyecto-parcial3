using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

[ApiController]
[Route("api/usuarios")]

public class ApiUsuariosController : ControllerBase
{





  private readonly IMongoCollection<Usuario> collection;
  public ApiUsuariosController()
{
   var client = new MongoClient(CadenasConexion.MONGO_DB);
   var database = client.GetDatabase("Escuela_Ricardo_Joselyn");
   this.collection = database.GetCollection<Usuario>("Usuarios");

}

    [HttpGet]
    public IActionResult ListarUsuarios()
    {
        var filter = FilterDefinition<Usuario>.Empty;
        var list = this.collection.Find(filter).ToList();
        return Ok(list);
    }
}