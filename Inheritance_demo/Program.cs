using System;

namespace Inheritance_demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee2 emp = new Employee2();
           int Salary= emp.salary;
           int Bonus= emp.bonus;
            Console.WriteLine("Salary of employee: " + Salary);
            Console.WriteLine("Bonus of employee2: " + Bonus);

        }
    }
}
