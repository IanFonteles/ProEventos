﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

       public IEnumerable<Evento> _evento = new Evento[]{
              new Evento(){
              EventoId = 1,
              Tema = "Angular 11 e .NET 5.0",
              Local = "Rio de Janeiro",
              DataEvento = "14/02/2022",
              QtdPessoas = 30,
              Lote = "1"
              },
              new Evento(){
              EventoId = 2,
              Tema = "Angular 11 e .NET 5.0",
              Local = "São paulo",
              DataEvento = "14/02/2022",
              QtdPessoas = 30,
              Lote = "1"
              }
       };
        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
           return _evento.Where(a=>a.EventoId ==id);
        }

         [HttpPost]
        public string Post()
        {
           return "Exemplo de Post"; 
        }

         [HttpPut("{id}")]
        public string Put(int id)
        {
           return $"Exemplo de put = {id} "; 
        }

        
         [HttpDelete("{id}")]
        public string Delete(int id)
        {
           return $"Exemplo de delete = {id} "; 
        }
    }
}
