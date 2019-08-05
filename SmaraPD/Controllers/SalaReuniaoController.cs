using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmaraPD.Models;

namespace SmaraPD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaReuniaoController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public SalaReuniaoController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("SalaReservada")]
        public IEnumerable<SalaReuniao> GetSalaReservada()
        {
            var dados = context.salaReunioes.Include(x => x.Clientes).Where(x => Convert.ToDateTime(x.DataEntrega) >= Convert.ToDateTime(DateTime.Now));
            return dados;
        }

        [HttpGet("SalaDisponivel")]
        public IEnumerable<SalaReuniao> GetSalaDisponivel()
        {
            var dados = context.salaReunioes.Include(x => x.Clientes).Where(x => Convert.ToDateTime(x.DataEntrega) <= Convert.ToDateTime(DateTime.Now));
            return dados;
        }

        //[HttpPost, Authorize(Roles = "Administrator")]
        [HttpPost]
        public IActionResult Post([FromBody] SalaReuniao sala)
        {
            if (ModelState.IsValid)
            {
                context.salaReunioes.Update(sala);
                context.SaveChanges();
            }
            else
            {
                return BadRequest(ModelState);
            }
            return Ok();
        }

    }
}