using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employess
{
    abstract class Employee
    {
        protected string empName;
        protected int empID;
        protected float currPay;
        protected int empAge;
        protected string empSSN;
        protected BenefitPackage empBenefits = new BenefitPackage();

        public class BenefitPackage
        {
            public enum BenefitPackageLevel
            {
                Standard,Gold,Platinum
            }
            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }

        public string SocialSecurityNumber
        {
            get { return empSSN; }
        }

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        public Employee() { }

        public Employee(string name, int id,float pay)
            : this(name, id, pay,0,"") { }

        public Employee(string name, int id, float pay,int age,string ssn)
        {
            empName = name;
            empID = id;
            empAge = age;
            currPay = pay;
            empSSN = ssn;
        }

        public virtual void DisplayStats()
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

        public virtual void GiveBonus(float amount)
        {
            currPay += amount;
        }

        public double GetBenefitCost()
        {
            return empBenefits.ComputePayDeduction();
        }

        public BenefitPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }
    }
}