using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5
{
    internal class Program
    {
        //Calculadora Científica Básica
        //Usa una variable global para guardar el último resultado calculado.
        //Crea métodos con variables locales para realizar:
        //Suma, resta, multiplicación y división.
        //Potencias y raíces cuadradas.
        //Cada vez que se realice una operación, el último resultado debe
        //actualizarse en la variable global
        public static double ultimoResultado = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Científica Básica");
            Console.WriteLine("Último resultado: " + ultimoResultado);
            Console.WriteLine("Seleccione una operación:");
            Console.WriteLine("1.Suma");
            Console.WriteLine("2.Resta");
            Console.WriteLine("3.Multiplicación");
            Console.WriteLine("4.División");
            Console.WriteLine("5.Potencia");
            Console.WriteLine("6.Raíz cuadrada");
            Console.WriteLine("7.Salir");
            int opcion = int.Parse(Console.ReadLine());
            while (opcion != 7)
            {
                switch (opcion)
                {
                    case 1:
                        Suma();
                        break;
                    case 2:
                        Resta();
                        break;
                    case 3:
                        Multiplicacion();
                        break;
                    case 4:
                        Division();
                        break;
                    case 5:
                        Potencia();
                        break;
                    case 6:
                        RaizCuadrada();
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

            }
            //metodo para sumar
            void Suma()
            {
                Console.WriteLine("Ingrese el primer número:");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número:");
                double num2 = double.Parse(Console.ReadLine());
                ultimoResultado = num1 + num2;
                Console.WriteLine("Resultado: " + ultimoResultado);
            }
            //metodo para restar
            void Resta()
            {
                Console.WriteLine("Ingrese el primer número:");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número:");
                double num2 = double.Parse(Console.ReadLine());
                ultimoResultado = num1 - num2;
                Console.WriteLine("Resultado: " + ultimoResultado);
            }
            //metodo para multiplicar
            void Multiplicacion()
            {
                Console.WriteLine("Ingrese el primer número:");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número:");
                double num2 = double.Parse(Console.ReadLine());
                ultimoResultado = num1 * num2;
                Console.WriteLine("Resultado: " + ultimoResultado);
            }
            //metodo para dividir
            void Division()
            {
                Console.WriteLine("Ingrese el primer número:");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número:");
                double num2 = double.Parse(Console.ReadLine());
                if (num2 != 0)
                {
                    ultimoResultado = num1 / num2;
                    Console.WriteLine("Resultado: " + ultimoResultado);
                }
                else
                {
                    Console.WriteLine("No se puede dividir entre cero");
                }
            }
            //metodo para potencia
            void Potencia()
            {
                Console.WriteLine("Ingrese la base:");
                double baseNum = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el exponente:");
                double exponente = double.Parse(Console.ReadLine());
                ultimoResultado = Math.Pow(baseNum, exponente);
                Console.WriteLine("Resultado: " + ultimoResultado);
            }
            //metodo para raiz cuadrada
            void RaizCuadrada()
            {
                Console.WriteLine("Ingrese el número:");
                double num = double.Parse(Console.ReadLine());
                if (num >= 0)
                {
                    ultimoResultado = Math.Sqrt(num);
                    Console.WriteLine("Resultado: " + ultimoResultado);
                }
                else
                {
                    Console.WriteLine("No se puede calcular la raíz cuadrada de un número negativo");
                }

            }
        } 
    }
}
