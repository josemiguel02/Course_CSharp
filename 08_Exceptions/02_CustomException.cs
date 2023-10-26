using System;

namespace Course_CSharp._08_Exceptions;

public class CustomException
{
    public CustomException()
    {
        try
        {
            Console.WriteLine("Ingresa un nombre:");
            var nombre = Console.ReadLine();

            if (string.IsNullOrEmpty(nombre))
            {
                throw new StringNullException("Nombre");
            }
        }
        catch (StringNullException e)
        {
            Console.WriteLine($"Error: {e.Message} - {e.GetType().Name}");
        }
    }
}

public class StringNullException : Exception
{
    public StringNullException(string mensaje) : base($"{mensaje} debe ser texto y requerido")
    {
    }
}