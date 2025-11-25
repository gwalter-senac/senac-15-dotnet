using Microsoft.AspNetCore.Mvc;
using Senac.GerenciamentoVeiculos.Domain;

namespace Senac.GerenciamentoVeiculos.Api.Controllers
{
    [ApiController]
    [Route("carro")]
    public class CarroController : ControllerBase
    {
        private ICarroService carroService;

        [HttpGet]
        public IActionResult GetCarros()
        {
            IList<Carro> carros = carroService.ObterCarros();

            return Ok(carros);
        }

        [HttpGet("{id}")]
        public IActionResult GetCarro(int id)
        {
            Carro carro = carros.FirstOrDefault(c => c.Id == id);

            return Ok(carro);
        }

        [HttpPost]
        public IActionResult CadastrarCarro([FromBody] Carro carro)
        {
            carros.Add(carro);

            return Created();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarCarro(int id)
        {
            Carro carro = carros.FirstOrDefault(c => c.Id == id);

            carros.Remove(carro);

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarCarro(int id, [FromBody] Carro carro)
        {
            Carro carroEncontrado = carros.FirstOrDefault(c => c.Id == id);

            carroEncontrado.Cor = carro.Cor;
            carroEncontrado.Placa = carro.Placa;
            carroEncontrado.Preco = carro.Preco;

            return Ok();
        }
    }
}
