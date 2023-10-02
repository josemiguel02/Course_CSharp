using System;

namespace Course_CSharp._03_FlowControlStructure;

public class WhileLoops
{
    public WhileLoops()
    {
        // WHILE Statement
        int i = 0;

        while (i < 10)
        {
            Console.WriteLine(i);
            i++;
        }


        Console.WriteLine("*******************************");


        // DO WHILE Statement
        int j = 0;

        do
        {
            Console.WriteLine("Se ejecuta al menos 1 vez");
        } while (j > 5);
    }
}