using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula2.entities;
using Microsoft.Extensions.Logging;
using aula2.services;
using aula2.UseCases.Heroi;
using aula2.DTO.Heroi.AdicionarHeroi;

namespace aula2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroiController : ControllerBase
    {

        private readonly ILogger<HeroiController> _logger;
        private readonly IHeroiService _heroi;
        private readonly IAdicionarHeroiUseCase _adicionarHeroiUseCase;

        public HeroiController(ILogger<HeroiController> logger, IHeroiService heroi, IAdicionarHeroiUseCase adicionarHeroiUseCase)
        {
            _logger = logger;
            _heroi = heroi;
            _adicionarHeroiUseCase = adicionarHeroiUseCase;
        }

      



        // GET api/values
        [HttpGet]
        public ActionResult TodosOsHerois()
        {
            return Ok(_heroi.RetornarListadeHeroi());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> heroi(int id)
        {
            return Ok(_heroi.RetornarHeroiporId(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult HeroiAdd([FromBody] AdicionarHeroiRequest novoHeroi)
        {
            return Ok(_adicionarHeroiUseCase.Executar(novoHeroi));
        }


        [HttpPost("{id}")]
        public IActionResult PoderAdd([FromBody] Poderes idpoder)
        {
            return Ok(_heroi.AdicionarPoderporId(idpoder));
        }

        [HttpPost("{id}")]
        public IActionResult FraquesaAdd([FromBody] Fraquesa idFraquesa)
        {
            return Ok(_heroi.AdicionarFraquesaporId(idFraquesa));
        }


        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult AtualizarHeroi(int id, [FromBody] Heroi novoHeroi)
        {
            return Ok(_heroi.AtualizarHeroi(novoHeroi));

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult DeleteHeroi(int id)
        {
            return Ok(_heroi.DeletarHeroi(id));
        }
    }
}
