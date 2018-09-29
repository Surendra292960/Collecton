using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Collections
{
    class QueueClass1
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();
            names.Enqueue("Sonu");
            names.Enqueue("Vikram");
            names.Enqueue("Sanjay");
            names.Enqueue("RatanSingh");
            names.Enqueue("RatanSingh");
            names.Enqueue(" ");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Peek element:" + names.Peek());
            Console.WriteLine("Dequeue:" + names.Dequeue());
            Console.WriteLine("After Dequeu Peek element:" + names.Peek());
            Console.Read();
        }
    }
}
