using System;

namespace Course_CSharp._10_TypeCasting;

/*
 * Casting o Conversiones de Tipos en C#
 * En C#, se pueden realizar las siguientes conversiones de tipos:
 * - Conversiones implícitas: no se requiere ninguna sintaxis especial porque la conversión siempre es correcta y
 * no se perderá ningún dato. Los ejemplos incluyen conversiones de tipos enteros más pequeños a más grandes, y
 * conversiones de clases derivadas a clases base.
 * - Conversiones explícitas: las conversiones explícitas requieren una expresión Cast. La conversión es necesaria
 * si es posible que se pierda información en la conversión, o cuando es posible que la conversión no sea correcta
 * por otros motivos.
 *
*/
public class TypeCasting
{
    public TypeCasting()
    {
        // Conversiones Implícitas
        int numInt = 1500;

        // Tipo int convertido a double
        double numDouble = numInt;

        int numInt2 = 2147483647;
        long numLong = numInt2;

        Console.WriteLine($"{numDouble} - {numDouble.GetType()}");
        Console.WriteLine($"{numLong} - {numLong.GetType()}");


        // Conversiones Explícitas
        double numDoub = 1234.7;
        int numInt3 = (int)numDoub;

        int numInt4 = 100;
        byte numByte = (byte)numInt4;

        Console.WriteLine($"{numInt3} - {numInt3.GetType()}");
        Console.WriteLine($"{numByte} - {numByte.GetType()}");
    }
}