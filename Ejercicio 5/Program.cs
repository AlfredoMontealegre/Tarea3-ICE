// EJERCICIO #5
// Calculadora Cientifica Basica
// Usa una variable global para guardar el ultimo resultado calculado
// Crea metodos con variables locales para realizar:
// Suma, resta, multiplicacion y division, potencias y raiz.
// Cada vez que se realice una operacion, el ultimo resultado
// debe actualizarse en la variable global.

// EJERCICIO #5
// Calculadora Científica Básica
// Usa una variable global para guardar el último resultado calculado
// Crea métodos con variables locales para realizar:
// Suma, resta, multiplicación y división, potencias y raíz.
// Cada vez que se realice una operación, el último resultado
// debe actualizarse en la variable global.

using System;

class Program
{
    // Variable global
    static double ultimoResultado = 0;

    // Diferentes operaciones y sus metoditosss
    static double Suma(double a, double b) => a + b;
    static double Resta(double a, double b) => a - b;
    static double Multiplicacion(double a, double b) => a * b;
    static double Division(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("[ERROR] No se puede dividir entre cero.");
            return 0;
        }
        return a / b;
    }
    static double Potencia(double a, double b) => Math.Pow(a, b);
    static double Raiz(double a) => Math.Sqrt(a);

    // Método principal
    static void Main(string[] args)
    {
        int opcion;
        double num1, num2;

        do
        {
            Console.WriteLine("--- Calculadora Científica Básica ---");
            Console.WriteLine("1 - Suma (+)");
            Console.WriteLine("2 - Resta (-)");
            Console.WriteLine("3 - Multiplicación (*)");
            Console.WriteLine("4 - División (/)");
            Console.WriteLine("5 - Potencia (^)");
            Console.WriteLine("6 - Raíz (√)");
            Console.WriteLine("7 - Salir");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"[Último resultado]: {ultimoResultado}");
            Console.Write("----> Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("[ERROR] Ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el primer número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    ultimoResultado = Suma(num1, num2);
                    Console.WriteLine($"[Resultado]: {ultimoResultado}");
                    break;

                case 2:
                    Console.Write("Ingrese el primer número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    ultimoResultado = Resta(num1, num2);
                    Console.WriteLine($"[Resultado]: {ultimoResultado}");
                    break;

                case 3:
                    Console.Write("Ingrese el primer número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    ultimoResultado = Multiplicacion(num1, num2);
                    Console.WriteLine($"[Resultado]: {ultimoResultado}");
                    break;

                case 4:
                    Console.Write("Ingrese el primer número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    ultimoResultado = Division(num1, num2);
                    Console.WriteLine($"[Resultado]: {ultimoResultado}");
                    break;

                case 5:
                    Console.Write("Ingrese la base: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el exponente: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    ultimoResultado = Potencia(num1, num2);
                    Console.WriteLine($"[Resultado]: {ultimoResultado}");
                    break;

                case 6:
                    Console.Write("Ingrese el número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    ultimoResultado = Raiz(num1);
                    Console.WriteLine($"[Resultado]: {ultimoResultado}");
                    break;

                case 7:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("[ERROR] Opción inválida.");
                    break;
            }

        } while (opcion != 7);

        Console.WriteLine("(Gracias por Usar)");
        Console.ReadKey();
    }
}
