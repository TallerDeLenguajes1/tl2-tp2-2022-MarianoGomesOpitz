using System;
using System.IO;

public class Alumno
{
    private int id, curso;
    private string nombre, apellido;
    private long dni;

    public int Id { get => id; set => id = value; }
    public int Curso { get => curso; set => curso = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public long Dni { get => dni; set => dni = value; }

    public Alumno() { }

    public Alumno(int c, string n, string a, long d)
    {
        this.Curso = c;
        this.Nombre = n;
        this.Apellido = a;
        this.Dni = d;

        string archivo = "";
        switch (c)
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

        var lectura = File.ReadAllText(archivo);
        if (lectura != "")
        {
            Console.WriteLine("Lectura: " + lectura);
            var linea = (lectura.Split("\n"))[(lectura.Split("\n")).Length - 2];
            Console.WriteLine("Linea: " + linea);
            Console.WriteLine("Num: " + (linea.Split(", "))[0]);
            this.Id = Convert.ToInt32((linea.Split(", "))[0]) + 1;
        }
        else
        {
            this.Id = 1;
        }
    }
}