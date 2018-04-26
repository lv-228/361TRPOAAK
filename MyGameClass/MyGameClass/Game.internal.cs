using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameClass
{
    partial class Game
    {
        private string gameName;
        private string gameGenre;
        private int gameAgeLimit { get; set; }
        private int gameDevCost { get; set; }
        static string gameOwner;

        public string name
        {
            get { return gameName; }
            set
            {
                if (value.Length > 100)
                {
                    Console.WriteLine("Название не может быть длиннее 100 символов");
                }
                else gameName = value;
            }
        }

        public string genre
        {
            get { return gameGenre; }
            set
            {
                if (value.Length > 50)
                {
                    Console.WriteLine("Жанр не может быть длиннее 50 символов");
                }
                else gameGenre = value;
            }
        }



        public string owner
        {
            get { return gameOwner; }
            set
            {
                gameOwner = value;
            }
        }
    }
}
