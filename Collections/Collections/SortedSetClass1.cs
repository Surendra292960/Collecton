using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Collections
{
    class SortedSetClass1
    {
        static void Main(string[] args)
        {
            //var names = new SortedSet<string>();
            //names.Add("Sonoo");
            //names.Add("Ankit");
            //names.Add("Peter");
            //names.Add("Irfan");
            //names.Add("Ankit");

            SortedSet<int> num = new SortedSet<int>() { 1, 2, 8, 4, 5, 6, 7, 9 ,9};

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
