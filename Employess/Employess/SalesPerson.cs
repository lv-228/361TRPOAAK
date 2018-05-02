using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employess
{
    class SalesPerson : Employee
    {
        public SalesPerson() { }
        public SalesPerson(string fullName, int age, int empID, float currPay, string ssn, int sNumber)
            :base(fullName, empID, currPay, age, ssn)
        {
            SalesNumber = sNumber;
        }
        public int SalesNumber { get; set; }

        public override sealed void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
                salesBonus = 10;
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                    salesBonus = 15;
                else
                    salesBonus = 20;
            }
            base.GiveBonus(amount * salesBonus);
        }
    }
}
