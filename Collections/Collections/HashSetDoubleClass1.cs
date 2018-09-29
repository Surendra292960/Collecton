using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Collections
{
    class HashSetDoubleClass1
    {
        static void Main(string[] args)
        {
            HashSet<double> d = new HashSet<double>();
            d.Add(1.5);
            d.Add(2.5);
            d.Add(3.5);
            d.Add(4.5);
            d.Add(5.5);
            d.Add(6.5);

          foreach(double i in d)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
