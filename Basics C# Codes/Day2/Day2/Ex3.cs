using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Ex3
    {
        static void Main(string[] args)
        {
            Category category = new Category();category.Display();// a=1  b=2

            category = new Category();category.Display();// a=1   b=3
            category = new Category(); category.Display();//a=1  b=4
        }
       
    }
    class Category
    {   int a;//0
        static int b;//0
        static Category()
        {
            b++;//1
        }
        public Category()
        {
            a++;//1
            b++;//2
        }
        public void Display()
        {
            Console.WriteLine("a={0} b={1}",a,b);
        }
    }
}
