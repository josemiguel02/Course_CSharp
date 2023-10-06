using System;

namespace Course_CSharp._04_DataTypeMethods;

public class Array
{
    public Array()
    {
        /*
         * GetValue()
         * Obtiene el valor del elemento especificado de la Array actual.
        */
        string[] arr = new string[] { "Item 1", "Item 2", "Item 3" };

        Console.WriteLine(arr.GetValue(1));


        /*
         * SetValue()
         * Establece el elemento especificado del Array actual en el valor especificado.
        */
        arr.SetValue("Item reemplazado", 2);


        /*
         * Clone()
         * Crea una copia superficial de la colección Array.
        */
        object arrCopia = arr.Clone();
        Console.WriteLine(arrCopia);


        Console.WriteLine("********************************");


        // Métodos Estáticos de la clase [Array]


        /*
         * Find(T[] array, predicate)
         * Busca un elemento que coincida con las condiciones definidas por
         * el predicado especificado y devuelve la primera aparición en
         * toda la matriz Array.
        */
        string[] frutas = { "Manzana", "Pera", "Uva", "Frutilla" };

        var frutilla = System.Array.Find(frutas, item => item == "Frutilla");
        Console.WriteLine(frutilla);
    }
}