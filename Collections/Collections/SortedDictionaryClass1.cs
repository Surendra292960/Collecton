using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Collections
{
    class SortedDictionaryClass1
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> names = new SortedDictionary<string, string>();
            names.Add("4", "surendra");
            names.Add("2", "Simar");
            names.Add("1", "James");
            names.Add("", "");
            names.Add("5", "Irfan");
            names.Add("3", "");

            foreach (KeyValuePair<string, string>kv in names)
            {
                Console.WriteLine(kv.Key + "," + kv.Value);
            }
                Console.Read();
        }
    }
}
