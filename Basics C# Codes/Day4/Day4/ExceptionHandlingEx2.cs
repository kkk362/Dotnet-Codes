using System;

namespace Day4
{
    class ExceptionHandlingEx2
    {
        static void Main(string[] args)
        {
            int a, b, c;
           
            try
            {
                Console.WriteLine("enter the value of a");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the value of b");
                b = int.Parse(Console.ReadLine());
                c = a / (a - b);
                Console.WriteLine("Result=" + c);//
            }
            catch(DivideByZeroException dzex )
            {

                // Console.WriteLine(ex.Message);
                Console.WriteLine(dzex.ToString());
            }
            catch (FormatException Fx)
            {

                // Console.WriteLine(ex.Message);
                Console.WriteLine(Fx.ToString());
            }
            Console.WriteLine("Done");
        }
    }

}