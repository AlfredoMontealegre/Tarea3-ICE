using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        //Juego de Adivinanza Mejorado
        //Usa una variable global para almacenar el número secreto.
        //Un método con variables locales debe pedir al usuario que adivine.
        //Otro método debe aumentar un contador global de intentos y mostrar un mensaje de acierto o error.

        private static int númeroSecretoGlobal = 6;
        private static int contadorIntentosGlobal = 0;

        static bool AdivinadoGlobal(int intento)
        {
            contadorIntentosGlobal++;
            if (intento == númeroSecretoGlobal)
            {
                Console.WriteLine("¡Correcto! Has adivinado el número en " + contadorIntentosGlobal + " intentos.");
                return true;
            }
            else
            {
                Console.WriteLine("Incorrecto. Intenta de nuevo.");
                return false;
            }
        }

        static void Main(string[] args)
        {
            bool adivinado = false;
            while (!adivinado)
            {
                Console.WriteLine("Adivina el número secreto del 1 al 10: ");
                string input = Console.ReadLine();
                int intento;
                if (int.TryParse(input, out intento))
                {
                    adivinado = AdivinadoGlobal(intento);
                }
                else
                {
                    Console.WriteLine("ERROR. Debe ingresar un número válido.");
                }
            }
        }
    }
}
