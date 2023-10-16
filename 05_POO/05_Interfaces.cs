using System;

namespace Course_CSharp._05_POO;

/*
 * Interfaces en C#
 * Una interfaz contiene las definiciones de un grupo de funcionalidades relacionadas que una class
 * o una struct no abstracta deben implementar.
*/

// Declarando una interfaz
// INombreInterfaz
public interface IVolable
{
    // Propiedades
    string Nombre { get; }

    // Métodos
    void Volar();
}

// Implementando la interfaz previamente declarada
public class Pajaro : IVolable
{
    public string Nombre { get; }

    public void Volar()
    {
        Console.WriteLine("El pájaro vuela!!");
    }
}

public class Avion : IVolable
{
    public string Nombre { get; }

    public void Volar()
    {
        Console.WriteLine("El avión vuela!!");
    }
}