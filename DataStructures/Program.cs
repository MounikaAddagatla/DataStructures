using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Is Datastructure  programs");
            LinkedListOperations linkedList = new LinkedListOperations();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();
            linkedList.RemoveLastNode();
            Console.WriteLine("After deleting last node");
            linkedList.Display();
            Console.WriteLine("Searching");
            linkedList.Search(30);
            linkedList.Display();
        }
    }
}
