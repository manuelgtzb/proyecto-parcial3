using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using proyecto_parcial3.Models;

namespace proyecto_parcial3.Controllers.Api;

[ApiController]
[Route("mi-proyecto")]
public class MiProyectoController : ControllerBase
{
    [HttpGet("integrantes")]
    public IActionResult Integrantes()
    {
        var proyecto = new MiProyecto
        {
            NombreIntegrante1 = "Ricardo Emmanuel Gutierrez Betancourt",
            NombreIntegrante2 = "Joselyn Anahi Rivera Vazquez"
        };
        return Ok(proyecto);
    }


    [HttpGet("presentacion")]

    public IActionResult Presentacion()
    {
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Escuela_Ricardo_Joselyn");
        var collecion = db.GetCollection<Equipo>("Equipo");

        var filter = FilterDefinition<Equipo>.Empty;
        var item = collecion.Find(filter).FirstOrDefault();

        return Ok(item);
    }
}