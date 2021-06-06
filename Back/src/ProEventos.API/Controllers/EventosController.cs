using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        // public IEnumerable<Evento> _evento = new Evento[]{
        //         new Evento() {
        //             EventoId = 1,
        //             Tema = "Angular 11 e .NET 5",
        //             Local = "Belo Horizonte",
        //             Lote = "1 Lote",
        //             QtdePessoas = 258,
        //             DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
        //             ImagemURL = "foto.png"
        //         },
        //         new Evento() {
        //             EventoId = 2,
        //             Tema = "Angular 11 e suas novidades",
        //             Local = "Sao Paulo",
        //             Lote = "2 Lote",
        //             QtdePessoas = 350,
        //             DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
        //             ImagemURL = "foto1.png"
        //         }
        //     };
        private readonly DataContext _context;
        public EventosController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento Get(int id)
        {
            return _context.Eventos.FirstOrDefault(e => e.EventoId == id);
        }
    }
}
