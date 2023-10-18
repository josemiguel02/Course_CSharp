using System;

namespace Course_CSharp._06_Generics;

public class Generics
{
    public Generics()
    {
        // Clase Generica
        ArregloGenerico<string> arregloGen = new ArregloGenerico<string>(2);

        arregloGen.Agregar(0, "Item 1");
        arregloGen.Agregar(1, "Item 2");

        Console.WriteLine(arregloGen.ToString());


        // Propiedades y Métodos Genéricos
        ResultadoOperacion<int> operacion = new ResultadoOperacion<int>();

        operacion.AgregarResultado(200);

        Console.WriteLine(operacion.ObtenerResultado());


        // Interfaces Genéricas
        MiClase miClase = new MiClase();

        Console.WriteLine(miClase.ObtenerDatos());
    }
}