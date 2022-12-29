using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_2
{
    class Ex3
    {
        static void Main(string[] args)
        {
            Color ob = new Color(); ob.showColor();
            ob = new Color1();ob.showColor();
            ob = new Color2();ob.showColor();
        }
     }
    class Color
    {   public virtual  void showColor()
        { Console.WriteLine("Red");
        }
    }
    class Color1 : Color
    {  public override void showColor()
        {
            Console.WriteLine("Blue");
        }
    }
    class Color2 : Color
    {
        public override void showColor()
        {
            Console.WriteLine("Yellow");
        }
    }
}
