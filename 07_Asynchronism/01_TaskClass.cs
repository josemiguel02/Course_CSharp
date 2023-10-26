using System;
using System.Threading;
using System.Threading.Tasks;

namespace Course_CSharp._07_Asynchronism;

/*
 * Task
 * La clase Task representa una operación asincrónica.
*/
public class TaskClass
{
    // Creación de instancias de la clase Task
    public static async Task CrearTareas()
    {
        var miTarea = new Task(() =>
        {
            Thread.Sleep(2000); // Simulando un Delay

            Console.WriteLine("Tarea interna de Task");
        });

        // Iniciando la tarea con el método Start()
        miTarea.Start();

        // Esperando a que termine la tarea usando la palabra reservada: await
        await miTarea;

        var miTarea2 = new Task(() =>
        {
            Thread.Sleep(2000);

            Console.WriteLine("Tarea 2 interna de Task");
        });

        miTarea2.Start();
        await miTarea2;

        Console.WriteLine("Han terminado las tareas!");
        Console.ReadKey();
    }
}