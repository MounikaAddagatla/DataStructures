using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Is Datastructure  programs");
            StackOperations stack = new StackOperations();
            stack.push(56);
            stack.push(30);
            stack.push(70);
            stack.Peek();
            stack.Pop();
            stack.Display();
        }
    }    
}
