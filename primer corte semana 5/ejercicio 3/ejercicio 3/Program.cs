using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    internal class Program
    {
        // Las variables globales deben estar fuera de Main
        public static int numeroSecreto = 8;
        public static int intentos = 0;

        static void Main(string[] args)
        {
            PedirAdivinanza();
        }

        // Método para pedir al usuario que adivine el número
        static void PedirAdivinanza()
        {
            Console.Write("Adivina el número secreto (entre 1 y 10): ");
            int adivinanza = int.Parse(Console.ReadLine());
            VerificarAdivinanza(adivinanza);
        }

        // Método para verificar la adivinanza y aumentar el contador de intentos
        static void VerificarAdivinanza(int adivinanza)
        {
            intentos++;
            if (adivinanza == numeroSecreto)
            {
                Console.WriteLine($"Correcto, Has adivinado el número en {intentos} intentos.");
            }
            else
            {
                Console.WriteLine("Incorrecto. Intenta de nuevo.");
                PedirAdivinanza();
            }
        }
    }
}
