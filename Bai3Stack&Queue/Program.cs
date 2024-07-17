using System.Collections;

namespace Bai3Stack_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Stack ===");
            Stack<int> stack = new Stack<int>();
            stack.Push(4);
            stack.Push(2);
            stack.Push(6);
            stack.Push(1);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());


            Console.WriteLine("=== Queue ===");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(4);
            queue.Enqueue(2);
            queue.Enqueue(6);
            queue.Enqueue(1);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());


        }
    }
}
