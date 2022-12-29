using System;
namespace Day4
{
    class ExceptionHandleEx1
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("enter the value of a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of b");
            b = int.Parse(Console.ReadLine());
            try
            {
                c = a / (a - b);
                Console.WriteLine("Result=" + c);
            }
            catch
            {

                Console.WriteLine("This is divide by zero error");
            }
            //no more than one catch of same type
            //catch
            //{

            //    Console.WriteLine("This is divide by zero error");
            //}

            Console.WriteLine("Done");
            Console.ReadKey();

        }
    }
}
