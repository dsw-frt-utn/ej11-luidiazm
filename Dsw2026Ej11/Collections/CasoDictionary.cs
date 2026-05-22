using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<string, Alumno> _alumnos;

    public CasoDictionary()
    {
        _alumnos = new Dictionary<string, Alumno>();
    }

    //metodo para agregar al diccionario
    public void AgregarAlDiccionario(string legajo, Alumno alumno)
    {
        if (!_alumnos.ContainsKey(legajo))
        {
            _alumnos.Add(legajo, alumno);
        }
    }

    // metodo para buscar un alumno usando la clave
    public Alumno BuscarPorLegajo(string legajo)
    {
        if (_alumnos.ContainsKey(legajo))
        {
            return _alumnos[legajo];
        }
        return null;
    }

    //metodo para retornar el diccionario
    public Dictionary<string, Alumno> DevolverDiccionario()
    {
        return _alumnos;
    }

    //eliminar alumno usando clave

    public void EliminarAlumno(string legajo)
    {
        _alumnos.Remove(legajo);
    }
}

