using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Game test = new Game("Heroes 7", 20,"FPS");
            Game.newDeveloper("EPIC");
            test.About();
            TimeUtilClass.printTime();
            TimeUtilClass.PrintDate();
            Console.ReadKey();
        }
    }
}
