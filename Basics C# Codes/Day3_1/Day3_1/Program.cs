using System;

namespace Day3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] ar = new int[4];
            //ar[0] = 101;
            //ar[1] = 102;
            //ar[2] = 103;
            //ar[3] = 104;
            //foreach(int i in ar)
            //    Console.WriteLine(i);//readonly and forward only loop


            //for(int i=0;i<ar.Length;i++)
            //    Console.WriteLine(ar[i]);

            //int[] ar1 = new int[5] { 3, 4, 5, 6,7 };

            //int[] ar2 = { 3, 4, 5, 6,5,6 };

            //2D array

            int[,] ar3 = { { 1, 2, 3 }, { 4, 5, 6 }, { 6, 7, 8 }, { 11, 12, 13 } };

            for(int i=0;i<4;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(ar3[i,j]+"\t");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();


        }
    }
}








