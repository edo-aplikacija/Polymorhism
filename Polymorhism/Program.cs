using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorhism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] empArray = new Employee[4];
            empArray[0] = new Employee() { ID = 1, Name = "Mike" };
            empArray[1] = new PartTimeEmployee() { ID = 2, Name = "John" };
            empArray[2] = new FullTimeEmployee() { ID = 3, Name = "Mary" };
            empArray[3] = new TemporaryEmployee() { ID = 4, Name = "Todd" };

            foreach (Employee emp in empArray)
            {
                emp.PrintName();
            }

            Employee e1 = new PartTimeEmployee() { ID = 1, Name = "Mike" };
            PartTimeEmployee e2 = new PartTimeEmployee() { ID = 2, Name = "John" };
            e1.SameMethod();
            e2.SameMethod();

            Console.ReadLine();
        }
    }

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        //public void PrintName()
        //{
        //    Console.WriteLine(this.Name);
        //}

        public virtual void PrintName()
        {
            Console.WriteLine(this.Name);
        }

        public void SameMethod()
        {
            Console.WriteLine("Base class");
        }
    }

    class PartTimeEmployee : Employee
    {
        public override void PrintName()
        {
            Console.WriteLine(this.Name + " Part time");
        }
        //public void SameMethod()
        //{
        //    Console.WriteLine("Derived class");
        //}
        // or with new keyword(same result)
        public new void SameMethod()
        {
            Console.WriteLine("Derived class");
        }
    }
    class FullTimeEmployee : Employee
    {
        public override void PrintName()
        {
            Console.WriteLine(this.Name + " Full time");
        }
    }
    class TemporaryEmployee : Employee
    {
        
    }
}
