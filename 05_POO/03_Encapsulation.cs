using System;

namespace Course_CSharp._05_POO;

/*
 * Encapsulamiento en C#
 * El encapsulamiento nos permite proteger los miembros (métodos y propiedades) de una clase y definir
 * cómo se accede a ellos desde otras partes del programa.
 * El encapsulamiento se logra mediante el uso de Modificadores de Acceso, como:
 * public, private, protected, entre otros.
*/
public class Animal
{
    // Atributo privado
    private string _nombre;


    // 1era Forma para declarar un Getter & Setter
    public string Nombre
    {
        get => _nombre;

        set => _nombre = value;
    }

    // 2da Forma para declarar un Getter & Setter
    public string Especie { get; set; }


    public void ObtenerInfo()
    {
        Console.WriteLine($"Hola soy un {Especie} y me llamo {Nombre}!");
    }
}

public class Perro : Animal
{
    public Perro()
    {
        Especie = "perro";
    }

    public void Ladrar()
    {
        Console.WriteLine("Guau guau!");
    }
}