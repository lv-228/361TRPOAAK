using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeDCircle o = new ThreeDCircle();
            o.Draw();
            //Вызов родительской реализации метода Draw
            ((Circle)o).Draw();
            Console.ReadLine();
        }
    }
}
