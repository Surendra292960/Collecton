using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Collections
{
    class ListClass
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            names.Add("Sonoo Jaiswal");
            names.Add("Ankit");
            names.Add("Peter");
            names.Add("irfan");

            foreach(string i in names)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
