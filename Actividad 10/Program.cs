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
                Console.WriteLine("--- AGREGAR NUEVOS PRODUCTOS ----");
                Console.WriteLine("Qué producto desea agregar?");
                objetoProductos.MenuProducto();
                int opcionDos = int.Parse(Console.ReadLine() ?? "");
                bool menuproducto = true;
                do
                {
                    try
                    {
                        switch (opcion)
                        {
                            case 1:
                                Telefono.AgregarTelefono(listaProductos);
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                        }

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Ingrese una opción válida..");
                        Console.WriteLine("Presione Enter para continuar...");
                        Console.ReadKey();
                    }

                } while (menuproducto);
        

                 break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            default:
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