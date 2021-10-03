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
    public class IMCControllers : ControllerBase
    {



        /*Nombre de la escuela: Universidad Tecnologica Metropolitana

        Asignatura: Aplicaciones Web Orientadas A Servicios


        Nombre del Maestro: Chuc Uc Joel Ivan


        Nombre de la actividad:"Calcular IMC"


        Nombre del alumno: Fabian Francisco Aguilar Rivero


        Cuatrimestre: 4


        Grupo: B


        Parcial: 1
        */

        [HttpGet]
        public IActionResult IMCResultado(double altura, double peso)

        {

            var R = new ObjetoImc();

            R.Peso = peso;

            R.Altura = altura / 100;

            var AlturaFinal = R.Altura;

            var IMC = peso / (AlturaFinal * AlturaFinal);

            var Decision = "";



            if (IMC < 18.5)

            {

                Decision = "Tienes un peso inferior a lo normal";

            }

            else

            {

                if (IMC >= 18.5 && IMC <= 24.9)

                {

                    Decision = "Tienes un peso normal";

                }

                else

                {

                    if (IMC >= 25.0 && IMC <= 29.9)

                    {

                        Decision = "Tienes un peso superior al normal";

                    }

                    else

                    {

                        Decision = "Tienes obesidad";

                    }

                }

            }

            var Peso = "Su IMC es: " + Convert.ToString(IMC) + "y su composicion corporal es de:  " + Decision;

            return Ok(Peso);

        }

    }

}
    

