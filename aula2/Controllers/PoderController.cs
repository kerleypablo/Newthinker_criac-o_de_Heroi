using Microsoft.AspNetCore.Mvc;
using aula2.entities;
using Microsoft.Extensions.Logging;
using aula2.Bordas.UseCase.Poder;
using aula2.DTO.Poder.Adicionar;
using aula2.DTO.Poder.Atulizar;

namespace aula2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoderController : ControllerBase
    {

        private readonly ILogger<PoderController> _logger;
        private readonly IAdicionarPoderUseCase _adicionarPoderUseCase;
        private readonly IListarPoderUseCase _listarPoderUseCase;
        private readonly IObterPoderUseCase _obterPoderUseCase;
        private readonly IAtualizarPoderUseCase _atualizarPoderUseCase;
        private readonly IRemoverPoderUseCase _removerPoderUseCase;

        public PoderController(ILogger<PoderController> logger,
            IAdicionarPoderUseCase adicionarPoderUseCase,
            IListarPoderUseCase listarPoderUseCase, 
            IObterPoderUseCase obterPoderUseCase,
            IAtualizarPoderUseCase atualizarPoderUseCase, 
            IRemoverPoderUseCase removerPoderUseCase)
        {
            _logger = logger;
            _adicionarPoderUseCase = adicionarPoderUseCase;
            _listarPoderUseCase = listarPoderUseCase;
            _obterPoderUseCase = obterPoderUseCase;
            _atualizarPoderUseCase = atualizarPoderUseCase;
            _removerPoderUseCase = removerPoderUseCase;
        }





        // GET api/values
        [HttpGet]
        public IActionResult TodosAsCategorias()
        {
            return Ok(_listarPoderUseCase.Executar());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Obter(int id)
        {
            return Ok(_obterPoderUseCase.Executar(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Adicionar([FromBody] AdicionarPoderRequest novoPoder)
        {
            return Ok(_adicionarPoderUseCase.Executar(novoPoder));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] AtualizarPoderRequest novoPoder)
        {
            return Ok(_atualizarPoderUseCase.Executar(id, novoPoder));

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_removerPoderUseCase.Executar(id));
        }
    }
}
