using Microsoft.AspNetCore.Mvc;

namespace Conversor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprimentoController : Controller
    {

        [HttpGet("kilometro/{valor:float}/{medida}")]
        public IActionResult ToKm(float valor, string medida)
        {
            if (valor < 0) return BadRequest("Insira um valor maior que 0");
            float milimetro = convertMilimetro(valor, medida);
            if (milimetro < 0) return BadRequest("medida inválida");

            return Ok("Valor em km: " + milimetro / 1000000);
        }

        [HttpGet("metro/{valor:float}/{medida}")]
        public IActionResult ToM(float valor, string medida)
        {
            if (valor < 0) return BadRequest("Insira um valor maior que 0");
            float milimetro = convertMilimetro(valor, medida);
            if (milimetro < 0) return BadRequest("medida inválida");

            return Ok("Valor em m: " + milimetro / 1000);
        }

        [HttpGet("centimetro/{valor:float}/{medida}")]
        public IActionResult ToCm(float valor, string medida)
        {
            if (valor < 0) return BadRequest("Insira um valor maior que 0");
            float milimetro = convertMilimetro(valor, medida);
            if (milimetro < 0) return BadRequest("medida inválida");

            return Ok("Valor em cm: " + milimetro / 100);
        }

        [HttpGet("milimetro/{valor:float}/{medida}")]
        public IActionResult ToMm(float valor, string medida)
        {
            if (valor < 0) return BadRequest("Insira um valor maior que 0");
            float milimetro = convertMilimetro(valor, medida);
            if (milimetro < 0) return BadRequest("medida inválida");

            return Ok("Valor em mm: " + milimetro);
        }

        private float convertMilimetro(float valor, string medida)
        {
            float milimetro;
            
            switch(medida)
            {
                case "mm":
                    milimetro = valor;
                    break;

                case "cm":
                    milimetro = valor * 10;
                    break;

                case "m":
                    milimetro = valor * 1000;
                    break;

                case "km":
                    milimetro = valor * 1000000;
                    break;

                default:
                    milimetro = -1;
                    break;
            }

            return milimetro;
        }

    }
}
