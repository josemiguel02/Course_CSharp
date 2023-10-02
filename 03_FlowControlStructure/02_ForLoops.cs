using System;
using System.Collections.Generic;

namespace Course_CSharp._03_FlowControlStructure;

public class ForLoops
{
    public ForLoops()
    {
        // FOR Statement
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        // Iterando un Array con un For
        string[] lenguajes = { "CSharp", "Java", "TypeScript", "Ruby" };

        for (int i = 0; i < lenguajes.Length; i++)
        {
            Console.WriteLine(lenguajes[i]);
        }


        Console.WriteLine("**************************************************");


        // FOREACH Statement
        string[] paises = new string[4] { "Ecuador", "Colombia", "Chile", "México" };

        foreach (var pais in paises)
        {
            Console.WriteLine(pais);
        }

        // Iterando Listas con Foreach
        List<string> listaCompras = new List<string>()
        {
            "Yogurt",
            "Cereales",
            "Frutas"
        };

        foreach (var item in listaCompras)
        {
            Console.WriteLine("Item: " + item);
        }
    }
}