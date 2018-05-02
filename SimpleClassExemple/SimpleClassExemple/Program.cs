using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExemple
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.name = "Henry";
            myCar.speed = 10;

            for(int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }
            Console.ReadLine();
        }
    }
}
