using System;

namespace Course_CSharp._08_Exceptions;

/*
 * Excepciones y Control de Excepciones
*/
public class Exceptions
{
    public Exceptions()
    {
        /*
         * throw Statement
         * La instrucción throw lanza una excepción.
         * NOTA: En una instrucción throw e;, el resultado de la expresión e debe poderse convertir
         * implícitamente a System.Exception.
        */
        Console.WriteLine("Ingresa un numero:");
        int miNum = int.Parse(Console.ReadLine() ?? "");

        if (miNum <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(miNum), "El numero debe ser positivo.");
        }


        /*
         * try-catch Statement
         * Use la instrucción try-catch para controlar las excepciones que pueden producirse
         * durante la ejecución de un bloque de código.
        */
        try
        {
            Console.WriteLine("Ingresa los numeros a dividir:");

            var num1 = int.Parse(Console.ReadLine() ?? "0");
            var num2 = int.Parse(Console.ReadLine() ?? "0");

            if (num2 == 0)
            {
                throw new DivideByZeroException();
            }

            Console.WriteLine($"Resultado: {num1 / num2}");
        }

        // En la cláusula catch se tiene que especificar el tipo de excepcion que desea controlar
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }


        /*
         * try-catch Statement con filtro de excepción when
         * Junto con un tipo de excepción, también puede especificar un filtro de excepción que examine aún
         * más una excepción y decida si el bloque correspondiente catch controla esa excepción.
        */
        try
        {
            Console.WriteLine("Ingresa un nombre:");
            var nombre = Console.ReadLine();

            if (string.IsNullOrEmpty(nombre))
            {
                throw new ArgumentNullException(nameof(nombre), "Nombre es requerido.");
            }
        }
        catch (Exception e) when (e is ArgumentException || e is ArgumentNullException)
        {
            Console.WriteLine($"Error: {e.Message}");
        }


        /*
         * try-catch-finally Statement
         * Use una instrucción try-catch-finally para controlar las excepciones que pueden producirse durante
         * la ejecución del bloque try y especificar el código que se debe ejecutar cuando el control
         * sale de la instrucción try.
        */
        try
        {
            throw new Exception("Error producido");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
        finally
        {
            Console.WriteLine("Se ejecuta siempre, al finalizar try...catch");
        }
    }
}