using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalindromoControllers : ControllerBase
    {


        /*Nombre de la escuela: Universidad Tecnologica Metropolitana

        Asignatura: Aplicaciones Web Orientadas A Servicios


        Nombre del Maestro: Chuc Uc Joel Ivan


        Nombre de la actividad:"Calcular Palindrono"


        Nombre del alumno: Fabian Francisco Aguilar Rivero


        Cuatrimestre: 4


        Grupo: B


        Parcial: 1
        */

        [HttpGet]
        public IActionResult PalindromoResultado(string Palabra)
        {
            var P = new Palindromo();
            P.palindromo = Palabra;
            var Final = string.Empty;
            var ContarPalin = Palabra;
            int i = ContarPalin.Length;
            var Decision = "";


            for (int j = i - 1; j >= 0; j--)
            {
                Final = Final + ContarPalin[j];
            }
            if (Final.ToLower().Replace(" ", string.Empty) == ContarPalin.ToLower().Replace(" ", string.Empty))
            {
                Decision = (ContarPalin + " es palindrome");
            }
            else
            {
                Decision = (ContarPalin + " no es palindrome");
            }
            int Semi = ContarPalin.Length - ContarPalin.Replace(" ", string.Empty).Count() + 1;
            var Resultado = ("La palabra ingresada: " + Decision.ToLower() + " y su invertido es: " + Final.ToLower()) + " la frase tiene" + Semi + " Palabras";
            return Ok(Resultado.ToLower());
        }
    }
}
