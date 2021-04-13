using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using aula2.Bordas.UseCase.Fraqueza;
using aula2.DTO.Fraquesa.Adicionar;
using aula2.DTO.Fraquesa.Atulizar;

namespace aula2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FraquezaController : ControllerBase
    {

        private readonly ILogger<FraquezaController> _logger;
        private readonly IAdicionarFraquezaUseCase _adicionarFraquezaUseCase;
        private readonly IListarFraquezaUseCase _listarFraquezaUseCase;
        private readonly IObterFraquezaUseCase _obterFraquezaUseCase;
        private readonly IAtualizarFraquezaUseCase _atualizarFraquezaUseCase;
        private readonly IRemoverFraquezaUseCase _removerFraquezaUseCase;

        public FraquezaController
            (ILogger<FraquezaController> logger
            , IAdicionarFraquezaUseCase adicionarHeroiUseCase
            , IListarFraquezaUseCase listarHeroiUseCase
            , IObterFraquezaUseCase obterHeroiUseCase
            , IAtualizarFraquezaUseCase atualizarHeroiUseCase
            , IRemoverFraquezaUseCase removerHeroiUseCase)
        {
            _logger = logger;
            _adicionarFraquezaUseCase = adicionarHeroiUseCase;
            _listarFraquezaUseCase = listarHeroiUseCase;
            _obterFraquezaUseCase = obterHeroiUseCase;
            _atualizarFraquezaUseCase = atualizarHeroiUseCase;
            _removerFraquezaUseCase = removerHeroiUseCase;
        }




        // GET api/values
        [HttpGet]
        public IActionResult TodosAsCategorias()
        {
            return Ok(_listarFraquezaUseCase.Executar());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Obter(int id)
        {
            return Ok(_obterFraquezaUseCase.Executar(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Adicionar([FromBody] AdicionarFraquezaResquest novoFraquesa)
        {
            return Ok(_adicionarFraquezaUseCase.Executar(novoFraquesa));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] AtualizarFraquezaRequest novoFraquesa)
        {
            return Ok(_atualizarFraquezaUseCase.Executar(id ,novoFraquesa));

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult DeleteFraquesa(int id)
        {
            return Ok(_removerFraquezaUseCase.Executar(id));
        }
    }
}
