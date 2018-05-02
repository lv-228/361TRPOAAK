using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        public string petName { get; set; }
        public Shape(string name = "NoName")
        {
            petName = name;
        }
        public abstract void Draw();
    }
}
