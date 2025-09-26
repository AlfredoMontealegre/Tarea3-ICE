using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        // variable global
        static int totalProductos = 0;

        static void Main(string[] args)
        {
            //metodo para agregar productos
            void AgregarProductos(int cantidad)
            {
                totalProductos += cantidad;
                Console.WriteLine($"Se han agregado {cantidad} productos. Total en inventario: {totalProductos}");
            }

            //metodo para retirar productos
            void RetirarProductos(int cantidad)
            {
                if (cantidad > totalProductos)
                {
                    Console.WriteLine("No hay suficientes productos en inventario para retirar esa cantidad.");
                }
                else
                {
                    totalProductos -= cantidad;
                    Console.WriteLine($"Se han retirado {cantidad} productos. Total en inventario: {totalProductos}");
                }
            }

            //metodo para consultar inventario
            void ConsultarInventario()
            {
                Console.WriteLine($"Total de productos en inventario: {totalProductos}");
            }

            // Menú de opciones
            while (true)
            {
                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("Agregar productos");
                Console.WriteLine("Retirar productos");
                Console.WriteLine("Consultar inventario");
                Console.WriteLine("Salir");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    //este case es para agregar productos usando el metodo AgregarProductos 
                    case "1":
                        Console.Write("Ingrese la cantidad a agregar: ");
                        if (int.TryParse(Console.ReadLine(), out int cantidadAgregar))
                        {
                            AgregarProductos(cantidadAgregar);
                        }
                        else
                        {
                            Console.WriteLine("Cantidad inválida.");
                        }
                        break;
                    //este case es para retirar productos usando el metodo RetirarProductos
                    case "2":
                        Console.Write("Ingrese la cantidad a retirar: ");
                        if (int.TryParse(Console.ReadLine(), out int cantidadRetirar))
                        {
                            RetirarProductos(cantidadRetirar);
                        }
                        else
                        {
                            Console.WriteLine("Cantidad inválida.");
                        }
                        break;
                    //este case es para consultar inventario usando el metodo ConsultarInventario
                    case "3":
                        ConsultarInventario();
                        break;
                    //este case es para salir del programa
                    case "4":
                        Console.WriteLine("Saliendo...");
                        return;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }
    }
}
