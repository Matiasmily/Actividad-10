using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Actividad_10
{
    public class Telefono : Productos
    {
        

        public string Color { get; set; }
        public double Tamaño { get; set; }
        

       

        public Telefono(string iD, string nombre, string marca, double precio, string color, double tamaño) : base(iD, nombre, marca, precio)
        {
            Color = color;
            Tamaño = tamaño;
           
        }

       

        public static void AgregarTelefono(List<Productos> listaProductos) 
        {
            Console.Clear();
            Console.WriteLine("--- TELÉFONOS ---");
            Console.Write("ID: ");
            string id = Console.ReadLine() ?? "";
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine() ?? "";
            Console.Write("Marca: ");
            string marca = Console.ReadLine() ?? "";
            Console.Write("Precio: ");
            double precio = double.Parse(Console.ReadLine() ?? "");
            Console.Write("Color : ");
            string color = Console.ReadLine() ?? "";
            Console.Write("Tamaño: ");
            double tamaño = double.Parse(Console.ReadLine() ?? "");
            Telefono nuevoTelefono = new Telefono(id, nombre, marca, precio, color, tamaño);
            listaProductos.Add(nuevoTelefono);
            Console.WriteLine("Produto añadido exitosamente");
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey();
        }

    }
}
