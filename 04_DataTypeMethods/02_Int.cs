using System;

namespace Course_CSharp._04_DataTypeMethods;

public class Int
{
    public Int()
    {
        /*
         * Equals
         * Devuelve un valor que indica si esta instancia equivale a un valor
         * de Int32 especificado.
        */
        int numInt = 23;
        Console.WriteLine(numInt.Equals(12));


        /*
         * GetTypeCode()
         * Devuelve el TypeCode para el tipo de valor Int32.
        */
        Console.WriteLine(numInt.GetTypeCode());


        Console.WriteLine("************************************");


        // Métodos Estáticos de la clase [Int32]

        /*
         * Parse()
         * Convierte la representación en forma de cadena de un número en el
         * entero de 32 bits con signo equivalente.
        */
        Console.WriteLine(int.Parse("45"));
    }
}