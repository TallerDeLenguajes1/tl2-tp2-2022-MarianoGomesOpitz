// See https://aka.ms/new-console-template for more information
using System;
using NLog;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger log = LogManager.GetCurrentClassLogger();

            Console.WriteLine("\nDatos del alumno");
            Console.WriteLine("Ingrese el apellido:");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el DNI:");
            long dni = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Ingrese curso:");
            Console.WriteLine("1: Atletismo, 2: Volley, 3: Futbol");
            int curso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el Id:");
            int id = Convert.ToInt32(Console.ReadLine());

            var alum = new Alumno(id, curso, nombre, apellido, dni);

            HelperDeArchivos.CargarContenido(alum);
        }
    }
}