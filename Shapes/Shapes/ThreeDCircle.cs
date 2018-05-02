using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class ThreeDCircle : Circle
    {
        protected new string shapeName;
        public new void Draw()
        {
            Console.WriteLine("Нарисован шар");
        }
    }
}
