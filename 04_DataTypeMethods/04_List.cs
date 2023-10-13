using System;
using System.Collections.Generic;

namespace Course_CSharp._04_DataTypeMethods;

public class List
{
    public List()
    {
        /*
         * Count
         * Obtiene el número de elementos incluidos en List<T>.
        */
        List<int> listaNum = new List<int>() { 1, 2, 3 };
        Console.WriteLine(listaNum.Count);


        /*
         * Add(T item)
         * Agrega un objeto al final de List<T>.
        */
        listaNum.Add(4);
        Console.WriteLine(string.Join(" - ", listaNum));


        /*
         * Insert (int index, T item)
         * Inserta un elemento en List<T> en el índice especificado.
        */
        listaNum.Insert(2, 5);


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


        /*
         * ToArray()
         * Copia los elementos de List<T> en una nueva matriz.
        */
        var arrayNum = listaNum.ToArray();
        Console.WriteLine(string.Join(" * ", arrayNum));

        /*
         * NOTA: Los demás Métodos de List<T>, son iguales a los métodos estáticos de la
         * clase [Array].
         * Ej.: Find(), FindAll(), FindIndex(), Exists(), TrueForAll(), ForEach(),
         * Reverse(), Sort(), etc...
        */
    }
}