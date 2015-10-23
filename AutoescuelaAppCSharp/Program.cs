using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoescuelaAppCSharp.Classes;

namespace AutoescuelaAppCSharp
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Nuevo usuario para dar de alta en la autoescuela");

            Console.WriteLine("Nombre: ");
            var nombre = Console.ReadLine();

            Console.WriteLine("Edad: ");
            int edad;
            Int32.TryParse(Console.ReadLine(), out edad);

            Console.WriteLine("Permiso actual: ");
            var permisoActual = Console.ReadLine();

            Console.WriteLine("Permiso deseado: ");
            var permiso = Console.ReadLine();

            try
            {
                var u = new Usuario(nombre, edad, permisoActual, permiso);
                Console.WriteLine("USUARIO AÑADIDO");
            }
            catch (UserEdadException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            catch (UserPermisoException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

            Console.ReadLine();



        }
    }
}
