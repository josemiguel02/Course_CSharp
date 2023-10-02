using System;
using System.Collections.Generic;

namespace Course_CSharp._02_DataStructures;

public class Lista
{
    public Lista()
    {
        // Declarando una Lista
        List<string> miLista = new List<string>();

        // Agregando elementos a una Lista
        miLista.Add("Item 1");
        miLista.Add("Item 2");
        miLista.Add("Item 3");
        miLista.Add("Item 4");

        // Eliminando elementos de una Lista
        miLista.Remove("Item 4");

        // Accediendo a valores de una Lista
        Console.WriteLine(miLista[0]);


        Console.WriteLine("********************************");


        // Declarando una Lista con elementos iniciales
        List<string> nombres = new List<string>()
        {
            "Kurt Cobain",
            "Courtney Love",
            "Dave Grohl",
            "Paul McCartney"
        };

        Console.WriteLine(nombres);
    }
}