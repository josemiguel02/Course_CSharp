using Course_CSharp._05_POO;

namespace Course_CSharp;

class Program
{
    public static void Main(string[] args)
    {
        // Creando una instancia de la clase Persona
        Persona persona1 = new Persona("Jhon Doe", 42);
        Persona persona2 = new Persona("Mac Miller", 26);

        // Llamando al método Saludar()
        persona1.Saludar();
        persona2.Saludar();


        Carro carro1 = new Carro("Tesla", "X", "rojo");
        carro1.ObtenerDatos();
    }
}