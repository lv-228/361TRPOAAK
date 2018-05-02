using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Person
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string SSN { get; set; }
        public Person(string fname, string lname, int page)
        {
            FirstName = fname;
            Lastname = lname;
            Age = page;
        }
        public Person() { }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override string ToString()
        {
            string myState;
            myState = string.Format("[First name: {0}; Last name: {1}; Age: {2};",FirstName, Lastname, Age);
            return myState;
        }

        public override bool Equals(object obj)
        {
            return obj.ToString() == this.ToString();
        }

        static void StaticMembersOfObject()
        {
            Person p3 = new Person("Sally", "Jones", 4);
            Person p4 = new Person("Sally", "Jones", 4);
            Console.WriteLine("P3 and P4 have same state: {0}", object.Equals(p3, p4));
            Console.WriteLine("P3 and P4 are pointing to same object {0}", object.ReferenceEquals(p3, p4));
        }
    }
}
