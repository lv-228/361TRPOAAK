using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameClass
{
    class Game
    {
        public string name;
        public string genre;
        public int ageLimit;
        public int devCost;
        static string owner;

        public void About()
        {
            Console.WriteLine("Название игры: {0} в жанре: {1} ограничения по возрасту {2} владелец {3}", name, genre,ageLimit,owner);
        }

        static Game()
        {
            Console.WriteLine("Статический конструктор сработал");
            owner = "Blizzard";
        }

        //Сцепление конструкторов
        public Game()
        {
        }

        public Game(string newname)
            :this(newname,0, "")
        {
        }

        public Game(int newAgeLimit)
            :this("",newAgeLimit,"")
        {
        }

        public Game(string name, int ageLimit, string genre)
        {
            this.name = name;
            this.ageLimit = ageLimit;
            this.genre = genre;
        }

        public static void newDeveloper(string newOwner)
        {
            owner = newOwner;
        }


    }
}
