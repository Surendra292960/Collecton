using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Collections
{
    class ListClass2
    {
        static void Main(string[] args)
        {
            var names = new List<string>() { "Sonu", "Manoj", "vimal", "surendra" };

            foreach (string i in names)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
