using System;
using System.Collections;//Non-Generic Collection

namespace Day3_1
{
    class Ex6
    {
        static void Main(string[] args)
        {
            /*
            Stack stack = new Stack();
            stack.Push("Raj");
            stack.Push("kumar");
            stack.Push("abhay");
            stack.Pop();
            foreach(string i in stack)
                Console.WriteLine(i);

            Console.WriteLine("Peek="+stack.Peek());
            */
          
         Queue Q = new Queue ();
         Q.Enqueue("Raj");
         Q.Enqueue("kumar");
         Q.Enqueue("abhay");
         Q.Dequeue();
         foreach(string i in Q)
             Console.WriteLine(i);

         Console.WriteLine("Peek="+Q.Peek());
   



        }
    }
}
