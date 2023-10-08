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


        /*
         * FindAll(T[] array, predicate)
         * Recupera todos los elementos que coinciden con las condiciones definidas
         * por el predicado especificado.
        */
        var frutasConA = System.Array.FindAll(frutas, fruta => fruta.Contains("a"));

        foreach (var fruta in frutasConA)
        {
            Console.WriteLine(fruta);
        }


        /*
         * FindIndex(T[] array, predicate)
         * Busca un elemento que cumpla las condiciones definidas por el predicado especificado y
         * devuelve el índice (index) de la primera aparición de un Array.
        */
        string[] planetas = new string[]
        {
            "Mercury", "Venus",
            "Earth", "Mars", "Jupiter",
            "Saturn", "Uranus", "Neptune"
        };
        var planetaIndex = System.Array.FindIndex(planetas, planeta => planeta.StartsWith("Ju"));
        Console.WriteLine(planetas[planetaIndex]);


        /*
         * ForEach()
         * Realiza la acción especificada en cada elemento de la matriz especificada.
        */
        System.Array.ForEach(planetas, planeta => { Console.WriteLine(planeta); });


        /*
         * Exists()
         * Determina si la matriz especificada contiene elementos que coinciden con
         * las condiciones definidas por el predicado especificado.
        */
        var existeUva = System.Array.Exists(frutas, item => item == "Uva");
        Console.WriteLine(existeUva);
    }
}