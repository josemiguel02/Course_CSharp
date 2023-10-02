using System;
using System.Collections.Generic;

namespace Course_CSharp._02_DataStructures;

public class Dictionaries
{
    public Dictionaries()
    {
        /*
         * Diccionarios en C#
         * Un diccionario en C# es una estructura de datos que almacena una colección de pares:
         * clave-valor, donde cada clave es única y se utiliza para acceder a su valor
         * correspondiente de manera eficiente. En otras palabras, un diccionario asocia
         * un valor con una clave específica, lo que permite buscar y recuperar rápidamente
         * valores utilizando esa clave.
        */

        Dictionary<string, int> edades = new Dictionary<string, int>();

        // Agregando elementos a un Diccionario
        edades["Jose"] = 23; // 1era Forma

        edades.Add("Jhon Doe", 42); // 2da Forma
        edades.Add("Jane Doe", 38);


        // Accediendo a valores de un Diccionario
        Console.WriteLine(edades["Jose"]);
        Console.WriteLine(edades["Jhon Doe"]);


        // Declarando un Diccionario con elementos iniciales
        Dictionary<string, string> colores = new Dictionary<string, string>()
        {
            { "azul", "#0000FF" },
            { "rojo", "#FF0000" },
            { "verde", "#008000" },
        };

        Console.WriteLine(colores["verde"]);
    }
}