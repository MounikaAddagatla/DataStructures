using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Is Datastructure  programs");
            QueueOperations queue = new QueueOperations();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Dequeue();
            queue.Display();
            Console.ReadLine();
        }
    }    
}
