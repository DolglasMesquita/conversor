using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conversor.API.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class TemperaturaController : Controller {

        [HttpGet("{tempBase}/{valor:float}/{tempFinal}")]
        public IActionResult ConversorTemperatura(string tempBase, float valor, string tempFinal) {

            float resultado;

            if (tempBase == "celsius") {
                switch (tempFinal) {
                    case "fahrenheit":
                        resultado = (0 * 9 / 5) + 32;
                        return Ok(resultado.ToString("F2", CultureInfo.InvariantCulture));
                    case "kelvin":
                        resultado = valor + 273.15f;
                        return Ok(resultado.ToString("F2", CultureInfo.InvariantCulture));
                    default:
                        return BadRequest("Temperatura final inexistente");
                }
            } else if (tempBase == "fahrenheit") {
                switch (tempFinal) {
                    case "celsius":
                        resultado = (valor - 32) * 5 / 9;
                        return Ok(resultado.ToString("F2", CultureInfo.InvariantCulture));
                    case "felvin":
                        resultado = (valor - 32) * 5 / 9 + 273.15f;
                        return Ok(resultado.ToString("F2", CultureInfo.InvariantCulture));
                    default:
                        return BadRequest("Temperatura final inexistente");
                }
            } else if (tempBase == "kelvin") {
                switch (tempFinal) {
                    case "celsius":
                        resultado = valor - 273.15f;
                        return Ok(resultado.ToString("F2", CultureInfo.InvariantCulture));
                    case "fahrenheit":
                        resultado = (valor - 273.15f) * 9 / 5 + 32;
                        return Ok(resultado.ToString("F2", CultureInfo.InvariantCulture));
                    default:
                        return BadRequest("Temperatura final inexistente");
                }
            }

            return BadRequest("Temperatura inicial inexistente");

        }
    }
}
