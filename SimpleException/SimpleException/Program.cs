using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);
            try
            {
                for (int i = 0; i < 10; i++)
                    myCar.Accelerate(10);
            }
            catch(Exception ex)
            {
                Console.WriteLine("\n***Error!***");
                Console.WriteLine("Метод :{0}", ex.TargetSite);
                Console.WriteLine("Класс :{0}", ex.TargetSite.DeclaringType);
                Console.WriteLine("Тип члена :{0}", ex.TargetSite.MemberType);
                Console.WriteLine("Сообщение :{0}", ex.Message);
                Console.WriteLine("Source :{0}", ex.Source);
                Console.WriteLine("Стэк: {0}", ex.StackTrace);
                Console.WriteLine("За помощью перейдите по ссылке: {0}", ex.HelpLink);
                Console.WriteLine("\n-> Custom Data:");
                if(ex.Data != null)
                {
                    foreach (DictionaryEntry de in ex.Data)
                        Console.WriteLine("-> {0}: {1}", de.Key, de.Value);
                }
            }
            Console.WriteLine("\n****** Исключение было обработанно *****");
            Console.ReadLine();
        }
    }
}
