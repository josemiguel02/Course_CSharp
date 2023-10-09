using System;
using System.Collections.Generic;

namespace Course_CSharp._04_DataTypeMethods;

public class List
{
    public List()
    {
        /*
         * Add(T item)
         * Agrega un objeto al final de List<T>.
        */
        List<int> listaNum = new List<int>() { 1, 2, 3 };

        listaNum.Add(4);
        Console.WriteLine(string.Join(" - ", listaNum));


        /*
         * Remove (T item)
         * Quita la primera aparición de un objeto específico de List<T>.
        */
        listaNum.Remove(2);
        Console.WriteLine(string.Join(", ", listaNum));


        /*
         * Contains (T item)
         * Determina si un elemento se encuentra en List<T>.
        */
        var existe5 = listaNum.Contains(5);
        Console.WriteLine(existe5);
    }
}