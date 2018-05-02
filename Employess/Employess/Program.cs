using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employess
{
    class Program
    {
        static void CastingExamples()
        {
            object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-111", 5);
            Employee moonUnit = new Manager("MoonUnit", 2, 3001, 350000, "232-55-3131", 6);
            GivePromotion(moonUnit);
            SalesPerson jill = new PTSalesPerson("Jill", 834, 3002, 100000, "111-232-2414", 90);
            GivePromotion(jill);
            GivePromotion((Employee)frank);
            Hexagon hex2 = frank as Hexagon;
            if (hex2 == null)
                Console.WriteLine("Frank не совместим с классом Hexagon");
        }

        static void GivePromotion(Employee emp)
        {
            Console.WriteLine("{0} был что-то там", emp.Name);
            if(emp is SalesPerson)
            {
                Console.WriteLine("{0} made {1} sale(s)!", emp.Name, ((SalesPerson)emp).SalesNumber);
                Console.WriteLine();
            }
            if(emp is Manager)
            {
                Console.WriteLine("{0} had {1} stock options...",emp.Name,((Manager)emp).StockOptions);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            CastingExamples();
            Console.ReadLine();
        }
    }
}
