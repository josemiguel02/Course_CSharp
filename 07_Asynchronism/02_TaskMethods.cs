using System;
using System.Threading.Tasks;

namespace Course_CSharp._07_Asynchronism;

public class TaskMethods
{
    public static async Task ObtenerMetodos()
    {
        /*
         * Task.Run(Action action)
         * Pone en cola el trabajo especificado para ejecutarlo en el grupo de subprocesos y devuelve un
         * objeto Task que representa ese trabajo.
        */
        var miTarea = Task.Run(() => Console.WriteLine("Mi Tarea"));

        await miTarea;


        /*
         * Task.Wait()
         * Espera a que se complete la ejecución del objeto Task.
        */
        var miTarea2 = Task.Run(() => Console.WriteLine("Mi Tarea #2"));

        miTarea2.Wait();


        /*
         * Task.Delay()
         * Crea una tarea que se completará después de un retraso.
        */
        var tareaConDelay = Task.Run(() =>
        {
            var delay = Task.Delay(TimeSpan.FromSeconds(2));
            delay.Wait();

            Console.WriteLine("Mi Tarea con 2s de Delay!");
        });

        tareaConDelay.Wait();


        /*
         * Task.WhenAll()
         * Crea una tarea que se completará cuando se hayan completado todas las
         * tareas proporcionadas.
        */
        var tarea1 = Task.Run(() => Console.WriteLine("Tarea 1"));
        var tarea2 = Task.Run(() => Console.WriteLine("Tarea 2"));
        var tarea3 = Task.Run(() => Console.WriteLine("Tarea 3"));

        // await Task.WhenAll(tarea1, tarea2, tarea3);


        /*
         * Task.WaitAll()
         * Espera que se complete la ejecución de todos los objetos Task proporcionados.
        */
        // Task.WaitAll(tarea1, tarea2, tarea3);


        /*
         * Task.WaitAny()
         * Espera a que se complete la ejecución de cualquiera de los objetos Task proporcionados.
        */
        Task.WaitAny(tarea1, tarea2, tarea3);


        Console.WriteLine("******* Luego de las Tareas *******");
        Console.ReadKey();
    }
}