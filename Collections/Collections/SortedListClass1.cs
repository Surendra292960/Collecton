using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Collections
{
    class SortedListClass1
    {
        static void Main(string[] args)
        {
            SortedList<int, string> names = new SortedList<int, string>();
            names.Add(1, "Surendra");
            names.Add(3, "Sujit");
            names.Add(6, "Sonum");
            names.Add(2, "Vijay");
            names.Add(5, "Anjee");
            names.Add(4, "Vijay");

            foreach (KeyValuePair<int,string>Kv in names)
            {
                Console.WriteLine(Kv.Key + "," + Kv.Value);
            }
            Console.Read();
        }
    }
}
