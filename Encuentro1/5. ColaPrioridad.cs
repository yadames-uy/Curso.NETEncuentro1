namespace Encuentro1;

public class ColaPrioridad
{
    public void Ejemplo()
    {
        /***
         *      List        --> Listas
         *      Dictionary  --> Mapas <llave, valor>
         *      Queue       --> Colas de tipo FIFO (la que se adiciona primero es la primera en salir)
         *      Stack       --> Colas de tipo LIFO (la última que se adiciona es la primera en salir)
         */

        PriorityQueue<string, int> priorityQueue = new PriorityQueue<string, int>();

        priorityQueue.Enqueue("Juan", 2);
        priorityQueue.Enqueue("Francisco", 1);
        priorityQueue.Enqueue("Jose", 3);

        priorityQueue.Dequeue();
    }
}