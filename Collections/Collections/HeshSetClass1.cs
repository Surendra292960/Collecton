using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Collections
{
    class HeshSetClass1
    {
        static void Main(string[] args)
        {
            //var names = new HashSet<string>();
            //names.Add("Sonu");
            //names.Add("Ankit");
            //names.Add("Peter");
            //names.Add("Irfan");
            //names.Add("Ankit");

            HashSet<int> num = new HashSet<int>();
            num.Add(1);
            num.Add(2);
            num.Add(3);
            num.Add(4);
            num.Add(5);
            num.Add(6);
            num.Add(6);
            num.Add(6);
            num.Add(6);

            num.Remove(1);
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
