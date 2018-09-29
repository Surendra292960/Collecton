using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Collections
{
    class StackClass2
    {
        static void Main(string[] args)
        {
            Stack<string> names = new Stack<string>();
            names.Push("sp");
            names.Push("sp");
            names.Push("sp");
            names.Push("sp");
            names.Push("sp");

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.Read();

        }
    }
}
