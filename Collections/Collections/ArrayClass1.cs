using System;
using System.Collections;


namespace Collections.Collections
{
    class ArrayClass1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList(10);
            Console.WriteLine(al.Capacity);
            al.Add(500);
            Console.WriteLine(al.Capacity);
            al.Add("Hello");
            al.Add(true);
            al.Add(2);
            Console.WriteLine(al.Capacity);
            al.Add(100);
            Console.WriteLine(al.Capacity); 

            foreach (object obj in al )
            {
                Console.WriteLine(obj+" ");
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
