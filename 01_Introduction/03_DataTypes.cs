using System;

namespace Course_CSharp._01_Introduction;

public class DataTypes
{
    public DataTypes()
    {
        /*
         * Tipos de Datos en C#
         * Los tipos de datos en CSharp se pueden clasificar en 2 categorías:
         * - Tipos de Valor
         * - Tipos de Referencia
         *
         * Referencia:
         * https://learn.microsoft.com/es-es/dotnet/csharp/tour-of-csharp/#types-and-variables
        */

        /*
         * TIPOS DE VALOR
         *
        */

        /*
         * Tipos Simples:
         *
        */

        // Enteros con Signos
        sbyte numSbyte = 12; // De -128 a 127 - (8 Bits)
        short numShort = 32; // De -32 768 a 32 767	- (16 Bits)
        int numInt = 500; // De -2.147.483.648 a 2.147.483.647 - (32 Bits)
        long numLong = 800; // De -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807 - (64 Bits)
        nint numNint = 800; // Depende de la plataforma - (64 o 32 Bits)

        Console.WriteLine(numInt);


        // Enteros sin Signos
        byte numByte = 0; // De 0 a 255 - (8 Bits)
        ushort numUshort = 65; // De 0 a 65.535 - (16 Bits)
        uint numUint = 100; // De 0 a 4.294.967.295 - (32 Bits)
        ulong numUlong = 180; // De 0 a 18.446.744.073.709.551.615 - (64 Bits)
        nuint numNuint = 800; // Depende de la plataforma - (64 o 32 Bits)

        Console.WriteLine(numNuint);


        // Caracteres
        char txtChar = 'A';
        string txtStr = "Hi, there";

        Console.WriteLine(txtStr);


        // Coma Flotante
        float numFloat = 3_000.5F; // (4 Bytes)
        double numDouble = 12.5D; // (8 Bytes)
        decimal numDecimal = 2.1m; // (16 Bytes)

        Console.WriteLine(numDecimal);


        // Booleano
        bool isActive = true;
        bool isOffline = false;

        Console.WriteLine(isActive);


        /*
         * Tipos de Enumeración
         * Un tipo de enumeración es un tipo de valor definido por un conjunto de constantes con
         * nombre del tipo numérico integral subyacente. Para definir un tipo de enumeración,
         * use la palabra clave enum y especifique los nombres de miembros de enumeración.
         * Ejemplo:
         * NOTA: Se declaran fuera de las clases...
        */

        /*
         * enum ErrorCode
           {
               None = 0,
               Unknown = 1,
               ConnectionLost = 100,
               OutlierReading = 200
           }
         */


        /*
         * Tipos de Estructura
         * Un tipo de estructura (o tipo struct) es un tipo de valor que puede encapsular datos
         * y funcionalidad relacionada. Para definir un tipo de estructura se usa la palabra
         * clave struct.
         * Ejemplo:
         * NOTA: Se declaran fuera de las clases...
        */

        /*
         * public struct Coords
           {
               public Coords(double x, double y)
               {
                   X = x;
                   Y = y;
               }

               public double X { get; }
               public double Y { get; }
           }
         *
         */


        /*
         * Tipos de valores que admiten NULL
         *
        */
        int? numNullable = null;

        Console.WriteLine(numNullable);


        /*
         * TIPOS DE REFERENCIA
         *
        */

        // Objetos => { key = "value" }
        var personObj = new { name = "Jhon", surname = "Doe" };

        Console.WriteLine(personObj);
        Console.WriteLine(personObj.name);
        Console.WriteLine(personObj.surname);


        /*
         * Clases
         * Las clases se declaran mediante la palabra clave class, como
         * se muestra en el siguiente ejemplo:
         *
         * class TestClass
         * {
         * }
        */


        /*
         * Interfaces
         * Una interfaz define un contrato. Cualquier class o struct que implemente ese
         * contrato debe proporcionar una implementación de los miembros definidos
         * en la interfaz.
         *
         * interface ISampleInterface
          {
              void SampleMethod();
          }
         *
        */


        /*
         * Matrices o Arrays
         * Puede almacenar varias variables del mismo tipo en una estructura de datos
         * de matriz.
         * Ejemplo:
        */

        string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

        Console.WriteLine(weekDays[0]);
        Console.WriteLine(weekDays[1]);
        Console.WriteLine(weekDays[2]);
        Console.WriteLine(weekDays[3]);
    }
}