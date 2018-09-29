using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Collections
{
    class HashSetClass2
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>() { "Sonu", "sachin", "virappan", "vikas","ganga" };

            foreach(string i in names)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
