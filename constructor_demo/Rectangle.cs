using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace default_constructor_demo
{
    public class Rectangle
    {
        public Rectangle() //default constructor
        {
            int height = 6;
            int width = 5;
            int area = height * width;
            Console.WriteLine("Area of default constructor:"+ area);
        }
        public Rectangle(int h,int w) //parameterized constructor
        {
            int height = h;
            int width = w;
            int area = height * width;
            Console.WriteLine("Area of parameterized constructor: " + area);
        }
    }
}
