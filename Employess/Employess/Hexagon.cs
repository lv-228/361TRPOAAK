using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employess
{
    class Hexagon
    {
        private string petName;
        public Hexagon() { }
        public Hexagon(string name){ petName = name; }
        public void Draw()
        {
            Console.WriteLine("Нарисован {0} гексагон", petName);
        }
    }
}
