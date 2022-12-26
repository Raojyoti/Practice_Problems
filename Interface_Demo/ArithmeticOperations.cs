using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Demo
{
    public interface ArithmeticOperations
    {
        public void Addition();
        public void Subtraction();
        public void Multiplication();
        public void Division();
    }
    class Calculations : ArithmeticOperations
    {
        public void Addition() 
        {
            int num1=5, num2=10;
            int result=num1+num2;
            Console.WriteLine("Additions result are: " + result);
        }
        public void Subtraction()
        {
            int num1 = 15, num2 = 10;
            int result = num1 - num2;
            Console.WriteLine("Subtraction result are: " + result);
        }
        public void Multiplication()
        {
            int num1 = 5, num2 = 10;
            int result = num1 * num2;
            Console.WriteLine("Multiplication result are: " + result);
        }
        public void Division()
        {
            double num1 = 255, num2 = 10;
            double result = num1 / num2;
            Console.WriteLine("Division result are: " + result);
        }
    }
}
