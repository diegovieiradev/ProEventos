using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventosController : ControllerBase
{
    private readonly DataContext _context;
    public EventosController(DataContext context)
    {        
            _context = context;
    }

    [HttpGet(Name = "GetEvento")]
    public IEnumerable<Evento> Get()
    {
        return _context.Eventos;        
    }

    [HttpGet("{id}")]
    public Evento GetById(int id)
    {
        return _context.Eventos.FirstOrDefault(evento => evento.EventoID == id);        
    }    

    [HttpPost(Name = "PostEvento")]
    public string Post()
    {
        return "Exemplo de POST";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Exemplo de PUT com id = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"Exemplo de DELETE com id = {id}";        
    }        
}
