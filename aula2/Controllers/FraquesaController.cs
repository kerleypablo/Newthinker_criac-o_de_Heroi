//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using aula2.entities;
//using Microsoft.Extensions.Logging;
//using aula2.services;

//namespace aula2.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class FraquesaController : ControllerBase
//    {

//        private readonly ILogger<FraquesaController> _logger;
//        private readonly IFraquesaService _fraquesa;

//        public FraquesaController(ILogger<FraquesaController> logger, IFraquesaService fraquesa)
//        {
//            _logger = logger;
//            _fraquesa = fraquesa;
//        }



//        // GET api/values
//        [HttpGet]
//        public ActionResult TodosAsCategorias()
//        {
//            return Ok(_fraquesa.RetornarListadeFraquesa());
//        }

//        // GET api/values/5
//        [HttpGet("{id}")]
//        public ActionResult<string> fraquesa(int id)
//        {
//            return Ok(_fraquesa.RetornarFraquesaporId(id));
//        }

//        // POST api/values
//        [HttpPost]
//        public IActionResult FraquesaAdd([FromBody] Fraquesa novoFraquesa)
//        {
//            return Ok(_fraquesa.AdicionarFraquesa(novoFraquesa));
//        }

//        // PUT api/values/5
//        [HttpPut("{id}")]
//        public IActionResult AtualizarFraquesa(int id, [FromBody] Fraquesa novoFraquesa)
//        {
//            return Ok(_fraquesa.AtualizarFraquesa(novoFraquesa));

//        }

//        // DELETE api/values/5
//        [HttpDelete("{id}")]
//        public IActionResult DeleteFraquesa(int id)
//        {
//            return Ok(_fraquesa.DeletarFraquesa(id));
//        }
//    }
//}
