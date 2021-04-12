using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula2.entities;
using Microsoft.Extensions.Logging;
using aula2.services;

namespace aula2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoderController : ControllerBase
    {

        private readonly ILogger<PoderController> _logger;
        private readonly IPoderService _poder;

        public PoderController(ILogger<PoderController> logger, IPoderService poder)
        {
            _logger = logger;
            _poder = poder;
        }



        // GET api/values
        [HttpGet]
        public ActionResult TodosAsCategorias()
        {
            return Ok(_poder.RetornarListadePoderes());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> poder(int id)
        {
            return Ok(_poder.RetornarPoderporId(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult PoderAdd([FromBody] Poder novoPoder)
        {
            return Ok(_poder.AdicionarPoder(novoPoder));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult AtualizarPoder(int id, [FromBody] Poder novoPoder)
        {
            return Ok(_poder.AtualizarPoder(novoPoder));

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult DeletePoder(int id)
        {
            return Ok(_poder.DeletarPoder(id));
        }
    }
}
