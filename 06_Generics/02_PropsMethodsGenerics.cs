namespace Course_CSharp._06_Generics;

// Propiedades y Métodos Genéricos
public class ResultadoOperacion<T>
{
    // Propiedad Genérica
    public T Respuesta { get; set; }


    // Método que acepta un tipo de dato Genérico
    public void AgregarResultado(T resultado)
    {
        Respuesta = resultado;
    }

    // Método que retorna un tipo de dato Genérico
    public T ObtenerResultado()
    {
        return Respuesta;
    }
}