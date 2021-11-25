using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Conversor.API.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class TemperaturaController : Controller {

        [HttpGet("celsius/{valor:float}/{tempFinal}")]
        public IActionResult celsiusTo(float valor, string tempFinal) {

            float valorFinal;

            switch (tempFinal)
            {
                case "celsius":
                    valorFinal = valor;
                    break;
                case "fahrenheit":
                    valorFinal = (valor * 9 / 5) + 32;
                    break;
                case "kelvin":
                    valorFinal = valor + 273.15f;
                    break;
                default:
                    return BadRequest("Insira uma temperatura final válida");
            }

            return Ok(valorFinal.ToString("F2", CultureInfo.InvariantCulture));
        }


        [HttpGet("fahrenheit/{valor:float}/{tempFinal}")]
        public IActionResult FahrenheitTo(float valor, string tempFinal) {

            float valorFinal;

            switch (tempFinal)
            {
                case "celsius":
                    valorFinal = (valor - 32) * 5 / 9;
                    break;
                case "fahrenheit":
                    valorFinal = valor;
                    break;
                case "kelvin":
                    valorFinal = (valor - 32) * 5 / 9 + 273.15f;
                    break;
                default:
                    return BadRequest("Insira uma temperatura final válida");
            }

            return Ok(valorFinal.ToString("F2", CultureInfo.InvariantCulture));

        }


        [HttpGet("kelvin/{valor:float}/{tempFinal}")]
        public IActionResult KelvinTo(float valor, string tempFinal) {

            float valorFinal;

            switch (tempFinal)
            {
                case "celsius":
                    valorFinal = valor - 273.15f;
                    break;
                case "fahrenheit":
                    valorFinal = (valor - 273.15f) * 9 / 5 + 32;
                    break;
                case "kelvin":
                    valorFinal = valor;
                    break;
                default:
                    return BadRequest("Insira uma temperatura final válida");
            };

            return Ok(valorFinal.ToString("F2", CultureInfo.InvariantCulture));
            

        }

    }
}
