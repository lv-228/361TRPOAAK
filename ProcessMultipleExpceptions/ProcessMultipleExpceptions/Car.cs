using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExpceptions
{
    class Car
    {
        public const int MaxSpeed = 100;
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }
        private bool carIsDead;
        private Radio theMusicBox = new Radio();

        public Car() { }
        public Car(string name,int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }
        public void CrankTunes(bool state)
        {
            theMusicBox.TurnOn(state);
        }
        public void Accelerate(int delta)
        {
            if (delta < 0)
                throw new
                    ArgumentOutOfRangeException("delta", "ускорение не может быть меньше 0!");
            if (carIsDead)
                Console.WriteLine("{0} is out of order...", PetName);
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    CurrentSpeed = 0;
                    carIsDead = true;
                    //throw new Exception(string.Format("{0} привысила скорость!", PetName));
                    CarIsDeadException ex = new CarIsDeadException(string.Format("{0} превысил скорость!", PetName),"You have a lead foot",DateTime.Now);
                    ex.HelpLink = "http://odnoklasniki.ru";
                    //ex.Data.Add("TimeStamp", string.Format("The car exploded at {0}", DateTime.Now));
                    //ex.Data.Add("Cause", "You have a lead foot");
                    throw ex;
                }
                else
                    Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
            }
        }

    }
}
