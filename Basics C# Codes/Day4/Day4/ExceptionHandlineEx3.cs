using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class ExceptionHandlineEx3
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
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {

                // Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                //Dispose the memory,close the connection,
                Console.WriteLine("Done============");//Close statement,memory release 
            }
            

        }
    }
}