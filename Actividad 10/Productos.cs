using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_10
{
    public class Productos
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public double Precio { get; set; }
        public Productos(List<Productos> listaProductos) { }
        public Productos(string iD, string nombre, string marca, double precio)
        {
            ID = iD;
            Nombre = nombre;
            Marca = marca;
            Precio = precio;
        }
        public void MostrarMenu()
        {
            Console.Clear();    
            Console.WriteLine("--- TIENDA DE PRODUCTOS ELECTRÓNICOS ---");
            Console.WriteLine("1. Agregar Nuevos Productos");
            Console.WriteLine("2. Ver todos los Productos");
            Console.WriteLine("3. Buscar productos");
            Console.WriteLine("4. Salir");
            Console.Write("Ingrese una opción: ");
        }
        public void MenuProducto()
        {
            Console.Clear(); 
            Console.WriteLine("1. Teléfono");
            Console.WriteLine("2. Ordenador");
            Console.WriteLine("3. Tablet");
            Console.WriteLine("4. Salir");
            Console.Write("Ingrese una opción: ");
        }

        public void AgregarDatosProducto(List<Productos> listaProductos)
        {
            Console.Write("ID: ");
            string id = Console.ReadLine()??"";
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine() ?? "";
            Console.Write("Marca: ");
            string marca = Console.ReadLine() ?? "";
            Console.Write("Precio: ");
            double precio = double.Parse(Console.ReadLine() ?? "");
        }

        //public void AgregarProductos(List<Productos> listaProductos)
        //{
        //    Console.WriteLine("--- AGREGAR NUEVOS PRODUCTOS ----");
        //    Console.WriteLine("Qué producto desea agregar?");
        //    MenuProducto();
        //    int opcion = int.Parse(Console.ReadLine()??"");
        //    bool menuproducto = true;
        //    do
        //    {
        //        try
        //        {
        //            switch(opcion)
        //            {
        //                case 1:
        //                    break;
        //                case 2:
        //                    break;
        //                case 3:
        //                    break;  
        //                case 4:
        //                    break;
        //            }

        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine("Error: Ingrese una opción válida..");
        //            Console.WriteLine("Presione Enter para continuar...");
        //            Console.ReadKey();
        //        }

        //    } while (menuproducto);
        }
    }
    
}
