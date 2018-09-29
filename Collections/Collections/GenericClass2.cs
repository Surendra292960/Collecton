using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Collections
{
    class GenericClass2<T>
    {

        private void Add<T1>(T1 a, T1 b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
            throw new NotImplementedException();

        }

        private void Sub<T1>(T1 a, T1 b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
            throw new NotImplementedException();
        }
        private void Mul<T1>(T1 a, T1 b)
        {

            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
            throw new NotImplementedException();
        }
        static void Main(string[] args)
        {
            GenericClass2<int> obj = new GenericClass2<int>();
            obj.Add<int>(10, 20);
            obj.Sub<int>(10, 20);
            obj.Mul<int>(10, 20);
            Console.Read();
        }
    }
}
