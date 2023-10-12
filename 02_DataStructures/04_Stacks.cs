using System;
using System.Collections;
using System.Collections.Generic;

namespace Course_CSharp._02_DataStructures;

public class Stacks
{
    public Stacks()
    {
        /*
         * STACK
         * Representa una colección de objetos no genérica, el último en entrar
         * es el primero en salir (LIFO).
        */

        // Declarando un Stack
        Stack miStack = new Stack();

        // Apilando elementos a un Stack
        miStack.Push("Hola");
        miStack.Push("Mundo");
        miStack.Push("!");

        // Eliminando un elemento de un Stack
        Console.WriteLine(miStack);


        /*
         * Stack<T>
         * Representa una colección LIFO (el último en entrar es el primero en salir)
         * de tamaño variable de instancias del mismo tipo especificado.
        */
        Stack<string> stackConTipo = new Stack<string>();

        stackConTipo.Push("Item 1");
        stackConTipo.Push("Item 2");
        stackConTipo.Push("Item 3");

        Console.WriteLine(stackConTipo);
    }
}