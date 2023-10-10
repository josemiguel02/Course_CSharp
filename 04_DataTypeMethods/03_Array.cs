using System;

namespace Course_CSharp._04_DataTypeMethods;

public class Array
{
    public Array()
    {
        /*
         * Length
         * Obtiene el número total de elementos de un Array.
        */
        string[] arr = new string[] { "Item 1", "Item 2", "Item 3" };
        Console.WriteLine(arr.Length);


        /*
         * GetValue()
         * Obtiene el valor del elemento especificado de un Array.
        */
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
         * Find(T[] array, Predicate<T> match)
         * Busca un elemento que coincida con las condiciones definidas por
         * el predicado especificado y devuelve la primera aparición en
         * toda la matriz Array.
        */
        string[] frutas = { "Manzana", "Pera", "Uva", "Frutilla" };

        var frutilla = System.Array.Find(frutas, item => item == "Frutilla");
        Console.WriteLine(frutilla);


        /*
         * FindAll(T[] array, Predicate<T> match)
         * Recupera todos los elementos que coinciden con las condiciones definidas
         * por el predicado especificado.
        */
        var frutasConA = System.Array.FindAll(frutas, fruta => fruta.Contains("a"));

        foreach (var fruta in frutasConA)
        {
            Console.WriteLine(fruta);
        }


        /*
         * FindIndex(T[] array, Predicate<T> match)
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
         * Exists(T[] array, Predicate<T> match)
         * Determina si la matriz especificada contiene elementos que coinciden con
         * las condiciones definidas por el predicado especificado.
        */
        var existeUva = System.Array.Exists(frutas, fruta => fruta == "Uva");
        Console.WriteLine(existeUva);


        /*
         * TrueForAll(T[] array, Predicate<T> match)
         * Determina si cada elemento de la matriz cumple las condiciones definidas por
         * el predicado especificado.
        */
        string[] carros = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

        var todosTerminanConA = System.Array.TrueForAll(carros, carro => carro.EndsWith("a"));
        Console.WriteLine(todosTerminanConA);


        /*
         * ForEach(T[] array, Action<T> action)
         * Realiza la acción especificada en cada elemento de la matriz especificada.
        */
        System.Array.ForEach(planetas, planeta => { Console.WriteLine(planeta); });


        /*
         * Reverse(Array array, int index, int length)
         * Invierte el orden de los elementos de una Array unidimensional o de una parte de la Array.
        */
        System.Array.Reverse(planetas, 0, planetas.Length);
        Console.WriteLine(string.Join(" - ", planetas));


        /*
         * Sort(T[] array)
         * Ordena los elementos en una matriz unidimensional.
        */
        System.Array.Sort(carros);
        Console.WriteLine(string.Join(", ", carros));
    }
}