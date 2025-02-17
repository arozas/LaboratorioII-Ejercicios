﻿using System;

namespace Introducción___I06___Años_bisiestos
{
    /*ALEJANDRO ALBERTO MARTÍN ROZAS
    * Ejercicio I06 - Años bisiestos
    * Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
    * Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
    * IMPORTANTE
    * Utilizar sentencias de iteración, selectivas y el operador módulo (%).
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoString;
            int numeroIngresado = new int();
            bool validacionNumeroIngresado = new bool();
            do
            {
                Console.WriteLine("\nIngrese un año a continuación:");
                numeroIngresadoString = Console.ReadLine();
                validacionNumeroIngresado = (!string.IsNullOrEmpty(numeroIngresadoString) && int.TryParse(numeroIngresadoString, out numeroIngresado)) && (numeroIngresado > 0);
                if (validacionNumeroIngresado == true)
                {
                    EsBisiesto(numeroIngresado);
                }
                else
                {
                    Console.WriteLine("ERROR. ¡ingresar un año valido!");
                }
            } while (Confirmar("¿Desea seguir?")); //No es parte del enunciado dejo esto asi por que se me hizo más facil probar rangos.
        }
        static void EsBisiesto(int numero)
        {
            int multiploDeCuatro = numero % 4;
            int multiploDeCien = numero % 100;
            int multiploDeCuatrocientos = numero % 400;

            if (multiploDeCuatro == 0)
            {
                if (multiploDeCien == 0)
                {
                    if (multiploDeCuatrocientos == 0)
                    {
                        Console.WriteLine($"El año {numero}, es bisiesto");
                    }
                    else
                    {
                        Console.WriteLine($"El año {numero}, no es bisiesto");
                    }
                }
                else
                { 
                    Console.WriteLine($"El año {numero}, es bisiesto");
                }
                
            }
            else
            {
                Console.WriteLine($"El año {numero}, no es bisiesto");
            }
        }
        static bool Confirmar(string pregunta)
        {
            bool retorno = false;
            ConsoleKeyInfo respuestaIngresada;
            do
            {
                Console.WriteLine($"\n{pregunta}");
                Console.WriteLine("<S/N>:");
                respuestaIngresada = Console.ReadKey();
                if (respuestaIngresada.Key == ConsoleKey.S)
                {
                    retorno = true;

                }
                else if (respuestaIngresada.Key == ConsoleKey.N)
                {
                    retorno = false;
                }
                else
                {
                    Console.WriteLine("\nERROR, DEBE INGRESAR UNA RESPUESTA <S/N>");
                }
            } while (respuestaIngresada.Key is not (ConsoleKey.S or ConsoleKey.N));

            return retorno;
        }
    }

}
