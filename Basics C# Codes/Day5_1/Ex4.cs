using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_1
{
    class Ex4
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>()
            {
           new Employee { Id = 101, Name = "Raj", Dob = DateTime.Parse("11/11/2012"), Salary = 444445.2, Gender = "Male", Dept = "CS" },
           new Employee { Id = 102, Name = "kumar", Dob = DateTime.Parse("09/11/2012"), Salary = 444464.2, Gender = "Male", Dept = "CS" },
           new Employee { Id = 103, Name = "Abhay", Dob = DateTime.Parse("06/11/2012"), Salary = 444447.2, Gender = "Male", Dept = "CS" }

            };
            //var is a implicit type local variable we can stored any type of Collection
            foreach(var i in emplist)
            {
                Console.WriteLine(i);

            }
            // //LINQ Query and Lambda Expression-------------Delegate---
            //select * from Employee order by id asc
            //select name from employee where id=1  from where select 
            //
            Console.WriteLine("After sort");
            var c = from ab in emplist
                    orderby ab.Id descending
                    select ab;
            foreach(var i in c)
                Console.WriteLine(i);

            Console.WriteLine("Search=======================");
            //LINQ search the using id
            var b = from ab1 in emplist
                    where ab1.Id == 101
                    select new {
                ab1.Id,ab1.Name
                          };
            foreach (var i in b)
                Console.WriteLine(i);
            //Lambda
            //(input-parameters) => expression
            var data = emplist.OrderBy(x => x.Id);
            var data1 = emplist.OrderByDescending(x => x.Id);

            //search using name in Lambda
            var data2 = emplist.Where(x => x.Name == "Raj");
            var data3 = emplist.Where(x => x.Id == 101 && x.Name == "Raj");
            var data4 = emplist.Where(x=> x.Name == "Raj").First();//error
            var data5 = emplist.Where(x => x.Name == "Raj").FirstOrDefault();//null
            var data6 = emplist.Where(x => x.Name == "Raj").Take(2);
            var data7 = emplist.Where(x => x.Name == "Raj").Skip(1);

















        }
    }
}
