using System;

namespace Course_CSharp._05_POO;

/*
 * Herencia en C#
 * La herencia en C# es un mecanismo que permite definir nuevas clases basadas en una
 * clase existente, a la que se llama clase base o superclase.
 * La clase nueva se llama clase derivada o subclase.
*/

// Clase Padre o ClaseBase
public class Vehiculo
{
    public string Marca;
    public string Modelo;
    public int Ruedas;

    public Vehiculo(string marca, string modelo, int ruedas)
    {
        Marca = marca;
        Modelo = modelo;
        Ruedas = ruedas;
    }


    public void Acelerar()
    {
        Console.WriteLine($"Soy {Marca}, estoy acelerando");
    }

    public void Frenar()
    {
        Console.WriteLine($"Soy {Marca}, estoy frenando!");
    }

    // Se establece virtual para que el método pueda ser sobreescrito por sus clases hijas
    public virtual void ObtenerDatos()
    {
        Console.WriteLine($"Marca: {Marca} \nModelo: {Modelo}");
    }
}

/*
 * Clase Hija o SubClase
 * La herencia en C# se implementa mediante la palabra clave «class» seguida del nombre de la subclase
 * y « : » seguida del nombre de la clase padre o base.
 * Ejemplo: Subclase : ClaseBase;
*/
public class Carro : Vehiculo
{
    public string Color;


    // Llamando al constructor de la clase padre se usa « : base() »
    public Carro(string marca, string modelo, string color) : base(marca, modelo, 4)
    {
        Color = color;
    }


    // Sobreescrimos el método de la Clase Padre
    public override void ObtenerDatos()
    {
        // Llamamos el método de la clase Padre con: «base»
        base.ObtenerDatos();

        Console.WriteLine($"Color: {Color} \nRuedas: {Ruedas}");
    }

    public void Girar(string direccion)
    {
        Console.WriteLine($"Soy {Marca}, estoy girando a la {direccion}!");
    }
}

// 2da Clase Hija
public class Moto : Vehiculo
{
    public int Cilindrada;

    public Moto(string marca, string modelo, int cilindrada) : base(marca, modelo, 2)
    {
        Cilindrada = cilindrada;
    }

    public override void ObtenerDatos()
    {
        base.ObtenerDatos();
        Console.WriteLine($"Cilindrada: {Cilindrada} \nRuedas: {Ruedas}");
    }

    public void HacerAcrobacia()
    {
        Console.WriteLine($"Soy {Marca}, estoy haciendo una acrobacia!");
    }
}