﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Collections
{
    class DictionaryClass1
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("1", "Sonoo");
            names.Add("2", "Peter");
            names.Add("3", "James");
            names.Add("4", "Ratan");
            names.Add("5", "Irfan");
            names.Add("", "");
            names.Add("7", "Irfan");
            names.Add("8", "");
            names.Add("6", "Manoj");


            foreach (KeyValuePair<string, string> kv in names)
            {
                Console.WriteLine(kv.Key + "," + kv.Value);
            }
            Console.Read();
        }
    }
}
