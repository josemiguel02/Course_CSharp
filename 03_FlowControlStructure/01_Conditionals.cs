using System;

namespace Course_CSharp._03_FlowControlStructure;

public class Conditionals
{
    public Conditionals()
    {
        // IF Statement
        if (true)
        {
            // Bloque de instrucciones que se ejecuta si se cumple la Condición
            Console.WriteLine("Es verdadero");
        }


        // IF/ELSE Statements
        int edad = 12;

        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad");
        }
        else
        {
            Console.WriteLine("Eres menor de edad");
        }


        // IF/ELSE IF/ELSE Statements
        int promedio = 8;

        if (promedio >= 7)
        {
            Console.WriteLine("Aprobado!");
        }
        else if (promedio == 5)
        {
            Console.WriteLine("Supletorio");
        }
        else
        {
            Console.WriteLine("Reprobado");
        }


        // SWITCH Statement
        int diaActual = DateTime.Now.Day;

        switch (diaActual)
        {
            case 1:
                Console.WriteLine("Domingo");
                break;

            case 2:
                Console.WriteLine("Lunes");
                break;

            case 3:
                Console.WriteLine("Martes");
                break;

            case 4:
                Console.WriteLine("Miercoles");
                break;

            case 5:
                Console.WriteLine("Jueves");
                break;

            case 6:
                Console.WriteLine("Viernes");
                break;

            case 7:
                Console.WriteLine("Sábado");
                break;

            default:
                Console.WriteLine("Día Incorrecto");
                break;
        }


        // Operador Ternario en C#
        int numero = 5;

        string resultado = numero > 0
            ? "El número es positivo"
            : "El número es negativo o cero";

        Console.WriteLine(resultado);
    }
}