using System;

namespace Course_CSharp._01_Introduction;

public class Variables
{
    public Variables()
    {
        /*
         * Una variable se puede definir especificando explícitamente su tipo o
         * utilizando la palabra clave: var.
         * Para que el compilador de C# deduzca su tipo en función del valor
         * asignado. El uso de se conoce como inferencia de tipos.
        */
        var variableImplicita = 23;

        // O tambien se puede especificar el Tipo de Dato.
        int variableExplicita = 50;


        // Reasignando un nuevo valor a la variable
        variableImplicita = 30;
        variableExplicita = 32;

        Console.WriteLine(variableImplicita);
        Console.WriteLine(variableExplicita);


        /*
         * Declarar constantes en C#
         * Para declarar una constante en C#, se usa la palabra clave «const»
         * seguida del tipo de datos y el nombre de la constante.
        */
        const int edadMaxima = 100;

        Console.WriteLine(edadMaxima);
    }
}