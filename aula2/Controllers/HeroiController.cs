using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using aula2.UseCases.Heroi;
using aula2.DTO.Heroi.Adicionar;
using aula2.DTO.Heroi.Atualizar;

namespace aula2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroiController : ControllerBase
    {

        private readonly ILogger<HeroiController> _logger;
        private readonly IAdicionarHeroiUseCase _adicionarHeroiUseCase;
        private readonly IListarHeroiUseCase _listarHeroiUseCase;
        private readonly IObterHeroiUseCase _obterHeroiUseCase;
        private readonly IAtualizarHeroiUseCase _atualizarHeroiUseCase;
        private readonly IRemoverHeroiUseCase _removerHeroiUseCase;

        public HeroiController(
            ILogger<HeroiController> logger,
            IAdicionarHeroiUseCase adicionarHeroiUseCase,
            IListarHeroiUseCase listarHeroiUseCase,
            IObterHeroiUseCase obterHeroiUseCase,
            IAtualizarHeroiUseCase atualizarHeroiUseCase,
            IRemoverHeroiUseCase removerHeroiUseCase)
        {
            _logger = logger;
            _adicionarHeroiUseCase = adicionarHeroiUseCase;
            _listarHeroiUseCase = listarHeroiUseCase;
            _obterHeroiUseCase = obterHeroiUseCase;
            _atualizarHeroiUseCase = atualizarHeroiUseCase;
            _removerHeroiUseCase = removerHeroiUseCase;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_listarHeroiUseCase.Executar());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Obter(int id)
        {
            return Ok(_obterHeroiUseCase.Executar(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Adicionar([FromBody] AdicionarHeroiRequest request)
        {
            return Ok(_adicionarHeroiUseCase.Executar(request));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] AtualizarHeroiRequest request)
        {
            return Ok(_atualizarHeroiUseCase.Executar(id, request));

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult DeleteHeroi(int id)
        {
            return Ok(_removerHeroiUseCase.Executar(id));
        }
    }
}
