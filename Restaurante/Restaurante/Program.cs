using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Restaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al restaurante");
            Restaurant miRestaurante = new Restaurant();
            miRestaurante.Dueño = "Juan Cruz Montes";
            miRestaurante.Direccion = "Cdte. Franco 6100";
            Console.WriteLine("Dueño: " + miRestaurante.Dueño + "\nDirección: " + miRestaurante.Direccion);
            Console.WriteLine("Ingrese la cantidad de clientes del día:");
            try
            {
                string comprobacion = Console.ReadLine();
                int cantidad = int.Parse(comprobacion);
                miRestaurante.CantClientes = cantidad;
                miRestaurante.CambiarEstadoDeRuido(cantidad);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("La cantidad de clientes fue: " + miRestaurante.CantClientes);
            Console.WriteLine(miRestaurante.EstadoDeRuido());
            Console.ReadKey();
        }
    }
}
