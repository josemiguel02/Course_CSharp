using System;
using System.Collections;

namespace Course_CSharp._02_DataStructures;

public class Queues
{
    public Queues()
    {
        /*
         * Queue
         * Representa una colección de objetos de tipo primero en entrar,
         * primero en salir (FIFO).
        */

        // Declarando un Queue
        Queue miQueue = new Queue();

        // Encolar elementos a un Queue
        miQueue.Enqueue(1);
        miQueue.Enqueue(2);
        miQueue.Enqueue(3);

        // Quitar y devolver el objeto al comienzo de Queue.
        miQueue.Dequeue();

        Console.WriteLine(miQueue);
    }
}