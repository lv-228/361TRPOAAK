using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExemple
{
    class Car
    {
        public string name;
        public int speed;

        public Car()
        {
            name = "Chuck";
            speed = 10;
        }

        public Car(string newname)
        {
            name = newname;
        }

        public Car(int newspeed, string newname)
        {
            speed = newspeed;
            name = newname;
        }

        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH.", name, speed);
        }

        public void SpeedUp(int delta)
        {
            speed += delta;
        }
    }
}
