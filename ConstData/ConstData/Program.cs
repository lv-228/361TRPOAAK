using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class MyMathClass
    {
        public const double PI = 3.14;
        public readonly double g = 9.8;

        public MyMathClass(double g)
        {
            this.g = g;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Значение PI: {0}",MyMathClass.PI);
            Console.ReadLine();
        }
    }
}
