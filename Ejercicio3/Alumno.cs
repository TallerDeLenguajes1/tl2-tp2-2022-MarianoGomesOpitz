/*public class Alumnos
{
    private List<Alumno> atletismo;
    private List<Alumno> futbol;
    private List<Alumno> volley;

    public List<Alumno> Atletismo { get => atletismo; set => atletismo = value; }
    public List<Alumno> Futbol { get => futbol; set => futbol = value; }
    public List<Alumno> Volley { get => volley; set => volley = value; }
}*/

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

    public Alumno(int i, int c, string n, string a, long d)
    {
        this.Id = i;
        this.Curso = c;
        this.Nombre = n;
        this.Apellido = a;
        this.Dni = d;
    }
}