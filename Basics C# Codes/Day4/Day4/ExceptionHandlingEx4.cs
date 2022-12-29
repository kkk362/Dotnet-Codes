
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class ExceptionHandlingEx4
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pls enter the age");
                int age = int.Parse(Console.ReadLine());
                if (age > 18)
                    Console.WriteLine("Your age is valid=" + age);
                else
                    throw new InvalidAgeException("Your age is Invalid");
            }
          
          

            catch (InvalidAgeException ex)
                {

                Console.WriteLine(ex.Message);
                }
        }
    }
    class InvalidAgeException:Exception
    {
        public InvalidAgeException(string message):base(message)
        {

        }
    }
        
}
