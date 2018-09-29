using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Collections
{
    class LinkedListNodeClass1
    {
        static void Main(string[] args)
        {
            var names = new LinkedList<string>();
            names.AddLast("Sonoo");
            names.AddLast("Ankit");
            names.AddLast("Peter");
            names.AddLast("");
            names.AddLast("Irfan");
           

            LinkedListNode<String> node = names.Find("Peter");
            names.AddBefore(node, "john");
            names.AddAfter(node, "Lucky");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
