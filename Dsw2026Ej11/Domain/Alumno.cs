namespace Dsw2026Ej11.Domain;

public class Alumno : EntidadBase
{
    
    public string Nombre { get; }
    public double Promedio { get; }

    public Alumno(string nombre, double promedio) : base()
    {
       
        Nombre = nombre;
        Promedio = promedio;
    }

    public Alumno(int id, string nombre, double promedio) : base (id)
    {
        Nombre = nombre;
        Promedio = promedio;
    }
    public override string ToString()
    {
        return $"{Id} - {Nombre} - Promedio: {Promedio}";
    }
}
