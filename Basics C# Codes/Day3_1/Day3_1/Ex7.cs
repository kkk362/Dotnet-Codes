using System;
using System.Collections;

namespace Day3_1
{
    class Ex7
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "raj");
            hashtable.Add(2, "rajee");
            hashtable.Add(3, "abhay");
            hashtable.Add(4, "kumar");

            Console.WriteLine(hashtable[4]);

            foreach(int i in hashtable.Keys)
                Console.WriteLine("Key="+i);
            foreach(string i in hashtable.Values)
                Console.WriteLine("Value="+i);

            foreach(DictionaryEntry i in hashtable)
                Console.WriteLine("key="+i.Key+"value="+i.Value);





        }
     }
}
