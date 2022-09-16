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
            try
            {
                char elec;
                do
                {
                    Console.WriteLine("\n¿Que desea hacer?");
                    Console.WriteLine("I: Insertar un nuevo alumno a un curso");
                    Console.WriteLine("L: Limpiar el contenido de un archivo");
                    Console.WriteLine("F: Finalizar el programa");
                    elec = Console.ReadKey().KeyChar;
                    switch (elec)
                    {
                        case 'F':
                        case 'f':
                            log.Debug("\nFinalizando programa...");
                            break;

                        case 'I':
                        case 'i':
                            string apellido, nombre;
                            long dni;
                            int curso;
                            EscribirDatos(out apellido, out nombre, out dni, out curso);
                            var alum = new Alumno(curso, nombre, apellido, dni);
                            HelperDeArchivos.CargarContenido(alum, log);
                            break;

                        case 'L':
                        case 'l':
                            HelperDeArchivos.LimpiarContenido(log);
                            break;

                        default:
                            log.Debug("\nEl caracter ingresado no forma parte de las opciones, ingrese de nuevo");
                            break;
                    }
                } while (elec != 'F' && elec != 'f');
            }
            catch (FileNotFoundException ex)
            {
                log.Error(ex, "El archivo que se está buscando no existe");
            }
            catch (DirectoryNotFoundException ex)
            {
                log.Error(ex, "El directorio o parte del archivo no existe");
            }
            catch (PathTooLongException ex)
            {
                log.Error(ex, "El path o nombre del archivo es muy largo");
            }
            catch (IOException ex)
            {
                log.Error(ex, "Un error de Entrada/Salid ha ocurrido");
            }
            catch (InvalidOperationException ex)
            {
                log.Error(ex, $"{DateTime.Now}: Se ingresado un valor inválido");
            }
            catch (OutOfMemoryException ex)
            {
                log.Error(ex, "No hay suficiente memoria para cuntinuar con la ejecución del programa");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                log.Error(ex, "El valor de un argumento excede con el rango de valor permitidos de una función invocada");
            }
            catch (FormatException ex)
            {
                log.Error(ex, "El formato de un argumento es inválido");
            }
            catch (OverflowException ex)
            {
                log.Error(ex, "Un valor numérico ha sufrido de un rebalse");
            }
            catch (ArgumentNullException ex)
            {
                log.Error(ex, "Un método que no recibe valores nulos ha recibido un valor nulo");
            }
            catch (System.Text.EncoderFallbackException ex)
            {
                log.Error(ex);
            }
            catch (ArgumentException ex)
            {
                log.Error(ex, "Uno de los argumentos transferido a un método es inválido");
            }
            catch (UnauthorizedAccessException ex)
            {
                log.Error(ex, "El sistema operativo ha denegado el acceso a un archivo por cuestiones de seguridad");
            }
            catch (NotSupportedException ex)
            {
                log.Error(ex, "Un flujo de información no soporta la acción que se quiere llevar a cabo");
            }
            catch (System.Security.SecurityException ex)
            {
                log.Error(ex, "Un error de seguridad ha ocurrido");
            }
        }

        private static void EscribirDatos(out string apellido, out string nombre, out long dni, out int curso)
        {
            Console.WriteLine("\nDatos del alumno");
            Console.WriteLine("Ingrese el apellido:");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el DNI:");
            dni = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Ingrese curso:");
            Console.WriteLine("1: Atletismo, 2: Volley, 3: Futbol");
            curso = Convert.ToInt32(Console.ReadLine());
        }
    }
}