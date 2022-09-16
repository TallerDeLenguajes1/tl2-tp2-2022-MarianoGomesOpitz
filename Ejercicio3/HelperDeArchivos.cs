using System;
using System.IO;
using NLog;

static class HelperDeArchivos
{
    public static void CargarContenido(Alumno A, Logger log)
    {
        string datos = Convert.ToString(A.Id) + ", " + A.Apellido + ", " + A.Nombre + ", " + Convert.ToString(A.Dni);

        string archivo = "";
        switch (A.Curso)
        {
            case 1:
                archivo = "csv\\Atletismo.csv";
                break;

            case 2:
                archivo = "csv\\Volley.csv";
                break;

            case 3:
                archivo = "csv\\Futbol.csv";
                break;

            default:
                break;
        }
        var escribir = new StreamWriter(File.Open(archivo, FileMode.Append));
        escribir.WriteLine(datos);
        escribir.Close();

        log.Info($"{DateTime.Now}: Se ha agregado un nuevo alumno al archivo {Path.GetFileName(archivo)}");
    }

    public static void LimpiarContenido(Logger log)
    {
        Console.WriteLine("\nSeleccione el archivo que desea limpiar:");
        Console.WriteLine("1: Atletismo, 2: Volley, 3: Futbol");
        int opcion = Convert.ToInt32(Console.ReadLine());
        string archivo = "";
        switch (opcion)
        {
            case 1:
                archivo = "csv\\Atletismo.csv";
                break;

            case 2:
                archivo = "csv\\Volley.csv";
                break;

            case 3:
                archivo = "csv\\Futbol.csv";
                break;

            default:
                break;
        }
        FileStream fileStream = File.Open(archivo, FileMode.Open);
        fileStream.SetLength(0);
        fileStream.Close();
        

        log.Info($"{DateTime.Now}: Se ha limpiado el contenido del archivo {Path.GetFileName(archivo)}");
    }
}