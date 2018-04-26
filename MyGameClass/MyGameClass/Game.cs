using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameClass
{
    partial class Game
    {

        public void About()
        {
            Console.WriteLine("Название игры: {0} в жанре: {1} ограничения по возрасту {2} владелец {3}", gameName, gameGenre,gameAgeLimit,gameOwner);
        }

        static Game()
        {
            Console.WriteLine("Статический конструктор сработал");
            gameOwner = "Blizzard";
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

        public Game(string newname, int ageLimit, string newgenre)
        {
            name = newname;
            gameAgeLimit = ageLimit;
            genre = newgenre;
        }

        public static void newDeveloper(string newOwner)
        {
            gameOwner = newOwner;
        }
    }
}
