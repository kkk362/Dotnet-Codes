using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Example2
    {
        static void Main(string[] args)
        {
            /*
             * Player p=new Test();//yes
             * //Hello Test  Hello Player             output:---Hello Player Hello Test
             * 
             * 
             */

            //  Player p = new Test();//yes

            // Test t = new Test(); 
            // Test t2=(Test)new Player();//compile time error


            //Player p = new Test();p.show();
            //Test t = new Test();t.show();t.show1();
            Player ob = new Test1();


        }
    }
    class Player
    {
       
        public void show() { Console.WriteLine("Show"); }
    }
    class Test : Player
    {
      
        public void show1() { Console.WriteLine("Show1"); }
    }
    class Test1 : Test
    {

        public void show2() { Console.WriteLine("Show2"); }
    }
}
