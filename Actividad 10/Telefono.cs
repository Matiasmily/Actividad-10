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
        public Telefono(List<Productos> listaProductos) : base(listaProductos)
        {
        }
    }
}
