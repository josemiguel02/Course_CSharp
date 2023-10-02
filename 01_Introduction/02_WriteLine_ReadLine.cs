using System;

namespace Course_CSharp._01_Introduction;

public class WriteLineReadLine
{
    public WriteLineReadLine()
    {
        /*
         *
         * La clase Console proporciona varios métodos para escribir datos en la consola,
         * como WriteLine y Write. WriteLine escribe una cadena en la consola y luego
         * hace un salto de línea, mientras que Write escribe una cadena en la consola
         * sin hacer un salto de línea.
        */

        Console.WriteLine("Escribiendo en una linea");


        /*
         *
         * Console.ReadLine(): Este método lee una línea de texto desde la consola y
         * la devuelve como una cadena.
        */
        Console.ReadLine();
    }
}