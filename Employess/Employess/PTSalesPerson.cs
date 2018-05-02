using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employess
{
    sealed class PTSalesPerson : SalesPerson
    {
        public PTSalesPerson() { }
        public PTSalesPerson(string fullName, int age, int empID, float currPay, string ssn, int sNumber)
            :base(fullName, age, empID, currPay, ssn, sNumber)
        {
        }
        public void getStatus()
        {
            Console.WriteLine("Пользователь:\n Имя: {0}\n Возраст: {1}\n ID: {2}\n Pay {3}\n ССН: {4}\n SalesNumber: {5}\n", Name, Age, ID, Pay, SocialSecurityNumber, SalesNumber);
        }
    }
}
