using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnagramaControllers : ControllerBase
    {
        [HttpGet]
        public IActionResult Anagrama(string frase1, string frase2)
        {
            var A = new Anagrama();
            A.anagrama1 = frase1.ToLower();
            A.anagrama2 = frase2.ToLower();
            bool ejecanagrama;
            var Anaresult = "";
            if (frase1.ToLower().Length != frase2.ToLower().Length)
            {
                ejecanagrama = false;
            }
            else
            {
                char[] let1 = frase1.ToCharArray();
                Array.Sort(let1);
                char[] let2 = frase2.ToCharArray();
                Array.Sort(let2);


                string fra1 = new string(let1);
                string fra2 = new string(let2);
                if (fra1.ToLower() == fra2.ToLower())
                {
                    ejecanagrama = true;
                }
                else
                {
                    ejecanagrama = false;
                }
            }
            if (ejecanagrama == true)
            {
                Anaresult = "Las palabras " + frase1 + " y " + frase2 + " Son Anagramas";
            }
            else
            {
                Anaresult = "Las palabras " + frase1 + " y " + frase2 + " No son Anagramas";
            }
            return Ok(Anaresult);
        }
    }
}
    

