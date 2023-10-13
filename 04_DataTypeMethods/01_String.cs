using System;

namespace Course_CSharp._04_DataTypeMethods;

public class String
{
    public String()
    {
        /*
         * Length
         * Devuelve la longitud de la cadena.
        */
        string txt = "Cadena de texto";
        Console.WriteLine(txt.Length);


        /*
         * ToUpper()
         * Convierte la cadena a mayúsculas.
        */
        string txt2 = "texto en mayuscula";
        Console.WriteLine(txt2.ToUpper());


        /*
         * ToLower()
         * Convierte la cadena a minúsculas.
        */
        string txt3 = "TEXTO EN MINUSCULA";
        Console.WriteLine(txt3.ToLower());


        /*
         * Substring(int startIndex, int length)
         * Devuelve una subcadena a partir de un índice dado.
        */
        string txt4 = "Hola mundo";
        Console.WriteLine(txt4.Substring(0, 5));


        /*
         * Replace(string oldValue, string newValue)
         * Reemplaza todas las apariciones de un valor en la cadena por otro.
        */
        Console.WriteLine(txt4.Replace("mundo", "strange!"));


        /*
         * Trim()
         * Elimina los espacios en blanco al principio y al final de la cadena.
        */
        string txt5 = "   Texto con espacios en blanco   ";
        Console.WriteLine(txt5.Trim());


        /*
         * Split(char separator)
         * Divide la cadena en un arreglo de subcadenas basado en un separador.
        */
        string[] partes = txt4.Split(' ');

        foreach (var palabra in partes)
        {
            Console.WriteLine(palabra);
        }


        /*
         * IndexOf(string value)
         * Busca en toda la cadena de string y devuelve el indice (index)
         * de la primera cadena encontrada.
        */
        Console.WriteLine(txt4.IndexOf("o"));


        /*
         * LastIndexOf(string value)
         * Busca en toda la cadena de string y devuelve el indice (index)
         * de la última cadena encontrada.
        */
        Console.WriteLine(txt4.LastIndexOf("o"));


        /*
         * Contains (string value)
         * Devuelve un valor booleano que indica si un carácter especificado aparece
         * dentro de esta cadena.
        */
        Console.WriteLine(txt5.Contains("."));


        /*
         * StartsWith(string value)
         * Devuelve un valor booleano que indica si la cadena COMIENZA con un
         * valor especificado.
        */
        Console.WriteLine(txt4.StartsWith("Hola"));


        /*
         * EndsWith(string value)
         * Devuelve un valor booleano que indica si la cadena TERMINA con un
         * valor especificado.
        */
        Console.WriteLine(txt4.EndsWith("!"));


        /*
         * PadLeft(int totalWidth, char paddingChar)
         * Devuelve una nueva cadena de una longitud especificada en la que el principio
         * de la cadena actual se rellena con espacios o con un carácter especificado.
        */
        string secuencial = "SEC";
        Console.WriteLine(secuencial.PadLeft(8, '0'));


        /*
         * PadRight(int totalWidth, char paddingChar)
         * Devuelve una nueva cadena de una longitud especificada en la que el final
         * de la cadena actual se rellena con espacios o con un carácter especificado.
        */
        Console.WriteLine(secuencial.PadRight(8, '0'));


        Console.WriteLine("**************************");


        // Métodos Estáticos de la clase [String]

        /*
         * IsNullOrEmpty(string value)
         * Indica si el valor de la cadena especificada es null o una cadena vacía ("").
        */
        string txt6 = "";
        Console.WriteLine(string.IsNullOrEmpty(txt6));


        /*
         * Concat(string? str0, string? str1, string? str2)
         * Concatena una o más cadenas de string con otra.
        */
        Console.WriteLine(string.Concat("Text1 ", "Text2 ", "Text3"));


        /*
         * Interpolación de Cadenas
        */
        string nombre = "Jhon";
        string apellido = "Doe";
        Console.WriteLine($"Nombres completos: {nombre} {apellido}");


        /*
         * Join(string separator, object?[] values)
         * Concatena (une) los elementos de una matriz especificada o los miembros de
         * una colección, usando el separador indicado entre todos los elementos.
        */
        string[] nombres = new[]
        {
            "Kurt Cobain",
            "Courtney Love",
            "Dave Grohl",
            "Paul McCartney"
        };
        Console.WriteLine(string.Join(" - ", nombres));


        /*
         * Compare(string strA, string strB)
         * Compara 2 String especificados y devuelve un entero que indica su posición
         * relativa en el criterio de ordenación.
        */
        string nombre1 = "Jack Smith";
        string nombre2 = "John Doe";
        Console.WriteLine(string.Compare(nombre1, nombre2));
    }
}