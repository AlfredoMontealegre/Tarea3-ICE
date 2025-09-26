using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        // Primero ponemos la variable global que almacena el total de productos en inventario
        static int totalProductos = 0;
        static void Main(string[] args)
        {
            //Sistema de Inventario simplificado, Declara una variable global que almacene el total de productos en inventario.
            //Crea métodos locales para:
            //✓ Agregar productos.
            //✓ Retirar productos.
            //✓ Consultar el inventario actual.
            //• Cada acción debe actualizar la variable global y mostrar los
            //resultados.
            // Variable global que almacena el total de productos en inventario
            // Ejemplo de uso del sistema de inventario
            // Variable local que almacena el total de productos en inventario
            // Métodos locales para el inventario

            // Iniciamos con un método local para agregar productos
            void AgregarProductos(int cantidad)
            {
                totalProductos += cantidad;
                Console.WriteLine($"Se han agregado {cantidad} productos. Total en inventario: {totalProductos}");
            }

            // Luego otro método local para retirar productos
            void RetirarProductos(int cantidad)
            {
                if (cantidad <= totalProductos)
                {
                    totalProductos -= cantidad;
                    Console.WriteLine($"Se han retirado {cantidad} productos. Total en inventario: {totalProductos}");
                }
                else
                {
                    Console.WriteLine("No hay suficientes productos en inventario para retirar esa cantidad.");
                }
            }

            //Y otro método local para consultar inventario
            void ConsultarInventario()
            {
                Console.WriteLine($"Total de productos en inventario: {totalProductos}");
            }

            // Aqui use un menú interactivo para probar los métodos
            int opcion;
            do
            {
                Console.WriteLine("\n--- Sistema de inventario ---");
                Console.WriteLine("1. Agregar productos");
                Console.WriteLine("2. Retirar productos");
                Console.WriteLine("3. Consultar inventario");
                Console.WriteLine("0. Salir");
                Console.Write("Elija una opción por favor: ");

                // Para validar entrada usamos el if, else, los casos y el bucle do while
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Ingrese un número válido.");
                    opcion = -1; // Para seguir el bucle
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese la cantidad de productos a agregar: ");
                        if (int.TryParse(Console.ReadLine(), out int agregar))
                            AgregarProductos(agregar);
                        else
                            Console.WriteLine("Cantidad inválida.");
                        break;

                    case 2:
                        Console.Write("Ingrese la cantidad de productos a retirar: ");
                        if (int.TryParse(Console.ReadLine(), out int retirar))
                            RetirarProductos(retirar);
                        else
                            Console.WriteLine("Cantidad inválida.");
                        break;

                    case 3:
                        ConsultarInventario();
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida, intente de nuevo.");
                        break;
                }

            } while (opcion != 0);
        }
    }
}