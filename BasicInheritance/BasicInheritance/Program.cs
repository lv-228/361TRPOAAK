﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            MiniVan myVan = new MiniVan();
            myVan.Speed = 10;
            Console.WriteLine("Мой мини-вен едет {0}", myVan.Speed);
            Console.ReadLine();
        }
    }
}
