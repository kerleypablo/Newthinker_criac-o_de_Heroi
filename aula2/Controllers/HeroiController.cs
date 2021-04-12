using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using aula2.services;
using aula2.UseCases.Heroi;
using aula2.DTO.Heroi.Adicionar;

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
        public IActionResult Listar()
        {
            return Ok(_heroi.RetornarListadeHeroi());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Obter(int id)
        {
            return Ok(_heroi.RetornarHeroiporId(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Adicionar([FromBody] AdicionarHeroiRequest novoHeroi)
        {
            return Ok(_adicionarHeroiUseCase.Executar(null));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] AdicionarHeroiRequest novoHeroi)
        {
            return Ok(_heroi.AtualizarHeroi(null));

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult DeleteHeroi(int id)
        {
            return Ok(_heroi.DeletarHeroi(id));
        }
    }
}
