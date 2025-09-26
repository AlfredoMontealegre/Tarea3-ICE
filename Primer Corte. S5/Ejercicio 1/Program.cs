using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {

        //Sistema de Inventario simplificado
        //Declara una variable global que almacene el total de productos en inventario.
        //Crea métodos locales para:
        //Agregar productos.
        //Retirar productos.
        //Consultar el inventario actual.
        //Cada acción debe actualizar la variable global y mostrar los resultados.

        private static int totalProductos = 0;
        private static int productos = 0;
        private static int inventario = 0;
        private static int inventarioActual = 0;
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Bienvenido al sistema de inventario.");
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Agregar productos.");
                Console.WriteLine("2. Retirar productos.");
                Console.WriteLine("3. Consultar el inventario actual.");
                Console.WriteLine("4. Salir");
                int opcion;
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida. Seleccione una opción del 1 al 4.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        int cantidadProductos = 0;
                        Console.Write("Ingrese la cantidad de productos a agregar: ");
                        int agregar;
                        if (int.TryParse(Console.ReadLine(), out agregar) && agregar > 0)
                        {
                            totalProductos += agregar;
                            Console.WriteLine($"Productos agregados. Total en inventario: {totalProductos}");
                        }
                        else
                        {
                            Console.WriteLine("Cantidad inválida.");
                        }
                        break;
                    case 2:
                        int retirarProductos = 0;
                        Console.Write("Ingrese la cantidad de productos a retirar: ");
                        int retirar;
                        if (int.TryParse(Console.ReadLine(), out retirar) && retirar > 0 && retirar <= totalProductos)
                        {
                            totalProductos -= retirar;
                            Console.WriteLine($"Productos retirados. Total en inventario: {totalProductos}");
                        }
                        else
                        {
                            Console.WriteLine("Cantidad inválida o insuficiente en inventario.");
                        }
                        break;
                    case 3:
                        Console.WriteLine($"El inventario actual es de {totalProductos} productos.");
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del sistema...");
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Seleccione una opción del 1 al 4.");
                        break;
                }
            }
        }
    }
}
