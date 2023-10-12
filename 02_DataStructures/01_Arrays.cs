using System;

namespace Course_CSharp._02_DataStructures;

public class Arrays
{
    public Arrays()
    {
        /*
         * Inicialización de Arrays en C#
         * Existen 2 formas de inicializar un Array en C#:
         * - Implícita
         * - Explícita.
        */


        /*
         * Inicialización Implícita:
         * La inicialización implícita permite asignar los valores directamente en
         * la declaración del array sin especificar su tamaño.
        */
        int[] numsImpli = { 1, 2, 3, 4, 5 };


        /*
         * Inicialización Explícita:
         * En la inicialización explícita, se especifica el tamaño del array y se
         * asignan los valores a cada elemento individualmente. Esto se puede hacer
         * utilizando la notación de corchetes y el índice del elemento.
        */
        int[] numsExpli = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Accediendo a valores de un Array
        Console.WriteLine(numsExpli[0]);
        Console.WriteLine(numsExpli[1]);
        Console.WriteLine(numsExpli[2]);
    }
}