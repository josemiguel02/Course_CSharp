using System;

namespace Course_CSharp._05_POO;

/*
 * Polimorfismo en C#
 * Polimorfismo es una palabra griega que significa "con muchas formas", es la capacidad que poseen los objetos
 * para tener múltiples formas. Tiene dos aspectos diferentes:
 *
 * 1. En tiempo de ejecución, los objetos de una clase derivada (hija) pueden ser tratados como objetos de una
 * clase base (padre) en lugares como parámetros de métodos y colecciones o matrices.
 *
 * 2. Las clases base pueden definir e implementar métodosvirtuales, y las clases derivadas pueden invalidarlos,
 * lo que significa que pueden proporcionar su propia definición e implementación.
*/

// Polimorfismo de Sobrecarga
public class Figura
{
    public string Color { get; set; }

    public Figura(string color)
    {
        Color = color;
    }

    public virtual void Dibujar()
    {
        Console.WriteLine("Dibujando una figura...");
    }

    public virtual double ObtenerArea()
    {
        return 0;
    }
}

public class Circulo : Figura
{
    public double Radio { get; set; }

    public Circulo(double radio, string color) : base(color)
    {
        Radio = radio;
    }

    public override void Dibujar()
    {
        Console.WriteLine("Dibujando un Circulo...");
    }

    public override double ObtenerArea()
    {
        return Math.PI * Radio * Radio;
    }
}

public class Triangulo : Figura
{
    public int Base { get; set; }
    public int Altura { get; set; }

    public Triangulo(int baseTri, int altura, string color) : base(color)
    {
        Base = baseTri;
        Altura = altura;
    }

    public override void Dibujar()
    {
        Console.WriteLine("Dibujando un Triangulo...");
    }

    public override double ObtenerArea()
    {
        return Base * Altura / 2;
    }
}

// 2do Ejemplo de Polimorfismo de Sobrecarga
public class CustomLista
{
    private string[] _arreglo;

    public CustomLista(short longitud)
    {
        _arreglo = new string[longitud];
    }

    // Sobrecargando Métodos
    public void Agregar(string item)
    {
        int indice = Array.FindIndex(_arreglo, item => item == null);
        _arreglo[indice] = item;
    }

    // Se utilizar el mismo nombre de un método anterior pero con una declaración única y diferente
    public void Agregar(short indice, string item)
    {
        _arreglo[indice] = item;
    }

    public override string ToString()
    {
        return string.Join(" - ", _arreglo);
    }
}

// Polimorfismo de Subtipo
public class Desarrollador : Persona
{
    public string Lenguaje { get; set; }

    public Desarrollador(string nombre, int edad, string lenguaje) : base(nombre, edad)
    {
        Lenguaje = lenguaje;
    }
}

public class PersonaExtension
{
    public string ObtenerInfo(Persona persona)
    {
        return $"Nombre: {persona.Nombre} \nEdad: {persona.Edad}";
    }
}