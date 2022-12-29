using System;
using System.Collections;
namespace Day3_1
{
    class Ex3
    {
        static void Main(string[] args)
        {


            //ArrayList is the class stored in System.Collections ,
            //using ArrayList clss we can create dynamically type of array of Object
            //Different methods and property we are using arraylist
            ArrayList arrayList = new ArrayList();//0
            Console.WriteLine("Capacity="+arrayList.Capacity);
            arrayList.Add(3.4);//size of  4 block of memory
            Console.WriteLine("Capacity=" + arrayList.Capacity);//4 block
            Console.WriteLine("Total Element="+arrayList.Count);//1
            arrayList.Add("raj");
            arrayList.Add("raj");
            arrayList.Add("raj");
            arrayList.Add("raj");
            Console.WriteLine("Capacity=" + arrayList.Capacity);//8
            Console.WriteLine("Total Element=" + arrayList.Count);//5



        }
    }
}
