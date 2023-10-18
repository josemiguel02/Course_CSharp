namespace Course_CSharp._06_Generics;

// Interfaces Genéricas
public interface IDatos<T>
{
    public T Dato { get; set; }

    public T ObtenerDatos();
}

// Implementando una Interface Genérica
public class MiClase : IDatos<string>
{
    public string Dato { get; set; }

    public string ObtenerDatos()
    {
        return "Datos respuesta";
    }
}