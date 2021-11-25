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

        [HttpGet("celsius/{valor:float}/{tempFinal}")]
        public IActionResult celsiusTo(float valor, string tempFinal) {

            float resultado = convertCelsius(tempFinal, valor);

            if (resultado != -1) {
                return Ok(resultado.ToString("F2", CultureInfo.InvariantCulture));
            } else {
                return BadRequest("Insira uma temperatura válida.");
            }

        }

        [HttpGet("fahrenheit/{valor:float}/{tempFinal}")]
        public IActionResult FahrenheitTo(float valor, string tempFinal) {

            float resultado = convertFahrenheit(tempFinal, valor);

            if (resultado != -1) {
                return Ok(resultado.ToString("F2", CultureInfo.InvariantCulture));
            }
            else {
                return BadRequest("Insira uma temperatura válida.");
            }

        }

        [HttpGet("kelvin/{valor:float}/{tempFinal}")]
        public IActionResult KelvinTo(float valor, string tempFinal) {

            float resultado = convertKelvin(tempFinal, valor);

            if (resultado != -1) {
                return Ok(resultado.ToString("F2", CultureInfo.InvariantCulture));
            }
            else {
                return BadRequest("Insira uma temperatura válida.");
            }

        }

        private float convertCelsius(string tempFinal, float valor) {

            float valorFinal;

            switch(tempFinal) {
                case "celsius":
                    valorFinal = valor;
                    break;
                case "fahrenheit":
                    valorFinal = (valor * 9/5) + 32;
                    break;
                case "kelvin":
                    valorFinal = valor + 273.15f;
                    break;
                default:
                    return -1;
            }

            return valorFinal;
        }

        private float convertFahrenheit(string tempFinal, float valor) {

            float valorFinal;

            switch (tempFinal) {
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
                    return -1;
            }

            return valorFinal;
        }

        private float convertKelvin(string tempFinal, float valor) {

            float valorFinal;

            switch (tempFinal) {
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
                    return -1;
            }

            return valorFinal;
        }

    }
}
