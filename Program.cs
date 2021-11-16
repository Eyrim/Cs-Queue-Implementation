using System;

namespace LinearQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinearQueue<string> queue = new LinearQueue<string>(MaxSize:10);
            
            queue.AddValue("1");
            queue.AddValue("2");
            queue.AddValue("3");
            queue.AddValue("4");
            queue.AddValue("5");
            queue.AddValue("6");
            queue.AddValue("7");
            queue.AddValue("8");
            queue.AddValue("9");
            queue.AddValue("10");
            
            Console.WriteLine(queue.RemoveValue());

            queue.AddValue("Question Mark");

            Console.WriteLine(queue.RemoveValue());

            Console.ReadKey();
        }
    }
}