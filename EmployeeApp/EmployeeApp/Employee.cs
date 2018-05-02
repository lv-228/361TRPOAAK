using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public Employee() { }

        public Employee(string name, int id,float pay)
            : this(name, id, pay,0) { }

        public Employee(string name, int id, float pay,int age)
        {
            empName = name;
            empID = id;
            empAge = age;
            currPay = pay;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Pay: {0}", currPay);
        }

        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Ошибка, имя не может быть длинее 15 символов");
                else
                    empName = value;
            }
        }

        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }

        public void GiveBonus(float amount)
        {
            currPay += amount;
        }
    }
}