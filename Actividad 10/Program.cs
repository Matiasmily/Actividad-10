// See https://aka.ms/new-console-template for more information
using Actividad_10;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Text.RegularExpressions;
List<Productos> listaProductos = new List<Productos>();
Productos objetoProductos = new Productos(listaProductos);
bool menu = true;

do
{
    try
    {
        objetoProductos.MostrarMenu();
        int opcion = int.Parse(Console.ReadLine()??"");
        switch (opcion)
        {
            case 1:
                objetoProductos.AgregarProductos(listaProductos);
                 break;
            case 2:
                objetoProductos.MostrarProductos(listaProductos);
                break;
            case 3:
                objetoProductos.Buscar(listaProductos);
                break;
            case 4:
                Console.WriteLine("\nUsted está saliendo del programa...");
                Console.WriteLine("Presione Enter para continuar");
                Console.ReadKey();
                menu = false;
                break;
            default:
                Console.WriteLine("\nIngrese una opción válida");
                Console.WriteLine("Presione Enter para continuar");
                Console.ReadKey();
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Ingrese una opción válida..");
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadKey();
    }
} while (menu);