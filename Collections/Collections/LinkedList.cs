using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Collections
{
    class LinkedList
    {
        static void Main(string[] args)
        {
            LinkedList<string> names = new LinkedList<string>();
            names.AddLast("Sonoo Jaiswal");
            names.AddLast("Ankit");
            names.AddLast("Peter");
            names.AddLast("Irfan");
            names.AddFirst("John");
            names.AddFirst("John");
            names.AddFirst(" ");

            foreach (string i in names)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
