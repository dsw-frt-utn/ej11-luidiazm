using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    
    //Agregar 3 alumnos a la lista

    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();
        Alumno a1 = new Alumno (60317,"Luisina", 9);
        Alumno a2 = new Alumno(12345, "Ana", 6);
        Alumno a3 = new Alumno(54321, "Facundo", 8);

        casoList.AgregarAlumno(a1);
        casoList.AgregarAlumno(a2);
        casoList.AgregarAlumno(a3);

        Console.WriteLine("Lista de Alumnos");
        foreach (var alumno in casoList.DevolverLista())
        {
            Console.WriteLine($"Legajo: {alumno.Id}) - Nombre: {alumno.Nombre} - promedio: {alumno.Promedio}");
        }

        Console.WriteLine("\n Buscar alumno existente ('Luisina')");
        Alumno encontrado = casoList.DevolverAlumno("Luisina");
        if (encontrado != null) Console.WriteLine($"Encontrado: {encontrado.Nombre} (ID: {encontrado.Id})");

        Console.WriteLine("\n Buscar alumno inexistente ('Carlos')");
        Alumno noEncontrado = casoList.DevolverAlumno("Carlos");
        if (noEncontrado == null) Console.WriteLine("No existe");

        Console.WriteLine("\n Eliminar a 'Ana' y listar ");
        casoList.EliminarAlumno(a2);
        foreach (var alumno in casoList.DevolverLista())
        {
            Console.WriteLine($"ID: {alumno.Id} - Nombre: {alumno.Nombre}");
        }

        Console.WriteLine("\n--- Eliminar el primer elemento y listar ---");
        casoList.EliminarPorPosicion(0); 
        foreach (var alumno in casoList.DevolverLista())
        {
            Console.WriteLine($"ID: {alumno.Id} - Nombre: {alumno.Nombre}");
        }
    
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDict = new CasoDictionary();

        Alumno a1 = new Alumno(100, "Maria", 9);
        Alumno a2 = new Alumno(101, "Lucas", 10);
        Alumno a3 = new Alumno(102, "Sofia", 5);

        casoDict.AgregarAlDiccionario(a1.Id.ToString(), a1);
        casoDict.AgregarAlDiccionario(a2.Id.ToString(), a2);
        casoDict.AgregarAlDiccionario(a3.Id.ToString(), a3);

        Console.WriteLine("\nDiccionario de Alumnos");
        foreach (var item in casoDict.DevolverDiccionario())
        {
            Console.WriteLine($"Clave (Legajo): {item.Key} - Nombre: {item.Value.Nombre} - Promedio: {item.Value.Promedio}");
        }

        Console.WriteLine("\nBuscar por clave existente ('101') ");
        Alumno encontradoDict = casoDict.BuscarPorLegajo("101");
        if (encontradoDict != null) Console.WriteLine($"Encontrado: {encontradoDict.Nombre}");

        Console.WriteLine("\nBuscar por clave inexistente ('999') ");
        Alumno noEncontradoDict = casoDict.BuscarPorLegajo("999");
        if (noEncontradoDict == null) Console.WriteLine("No existe");

        Console.WriteLine("\nEliminar por clave ('102') y listar");
        casoDict.EliminarAlumno("102");
        foreach (var item in casoDict.DevolverDiccionario())
        {
            Console.WriteLine($"Clave (Legajo): {item.Key} - Nombre: {item.Value.Nombre}");
        }
    }
    

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine($"1. Primer libro: {casoLinq.GetPrimero()?.Titulo}");
        Console.WriteLine($"2. Último libro: {casoLinq.GetUltimo()?.Titulo}");
        Console.WriteLine($"3. Suma total de precios: {casoLinq.GetTotalPrecios():C}");
        Console.WriteLine($"4. Promedio de precios: {casoLinq.GetPromedioPrecios():C}");
        Console.WriteLine("\n5. Libros con Id > 15:");
        foreach (var libro in casoLinq.GetListById())
            Console.WriteLine($"- {libro.Titulo} (ID: {libro.Id})");

        Console.WriteLine("\n6. Lista de títulos y precios:");
        foreach (var libroFormateado in casoLinq.GetLibros())
            Console.WriteLine($"- {libroFormateado}");

        var mayor = casoLinq.GetMayorPrecio();
        Console.WriteLine($"\n7. Libro más caro: {mayor?.Titulo} ({mayor?.Precio:C})");

        var menor = casoLinq.GetMenorPrecio();
        Console.WriteLine($"8. Libro más barato: {menor?.Titulo} ({menor?.Precio:C})");

        Console.WriteLine("\n9. Libros con precio mayor al promedio:");
        foreach (var libro in casoLinq.GetMayorPromedio())
            Console.WriteLine($"- {libro.Titulo} ({libro.Precio:C})");

        Console.WriteLine("\n10. Libros ordenados (Z-A):");
        foreach (var libro in casoLinq.GetLibrosOrdenadosDescendente())
            Console.WriteLine($"- {libro.Titulo}");
    }
}
