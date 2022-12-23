using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{

    public IEnumerable<Evento> _evento = new Evento[]{
        new Evento() {
            EventoID = 1,
            Tema = "Angular 11 e .NET 5",
            Local = "Campina Grande",
            Lote = "1º Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            ImagemURL = "foto.png"
        }        
    };
    public EventoController()
    {        
    }

    [HttpGet(Name = "GetEvento")]
    public IEnumerable<Evento> Get()
    {
        return _evento;        
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        return _evento.Where(evento => evento.EventoID == id);        
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
