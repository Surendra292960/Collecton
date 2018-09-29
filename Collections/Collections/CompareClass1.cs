using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Collections
{
    class CompareClass1
    {
        public bool Compare(int a, int b)
        {
            if (a == b)
                return true;
                return false;
        }
        public bool Compare(object a, object b)
        {
            if (a.Equals(b))
                return true;
                return false;
        }
        public bool Compare<T>(T a, T b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            CompareClass1 obj = new CompareClass1();

            bool result = obj.Compare<float>(10.5f, 10.5f);
            Console.WriteLine(result);
            Console.WriteLine();
            Console.Read();
            }
        }
    }

