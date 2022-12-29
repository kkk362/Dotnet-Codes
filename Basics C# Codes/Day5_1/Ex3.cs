using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_1
{
 //   create a Collection of Employee-----------id   name      dob     salary    gender    dept
 //how to create complex Collection

    class Ex3
    {
        static void Main(string[] args)
        {
            List<Employee> lst = new List<Employee>();
            lst.Add(new Employee { Id = 101, Name = "Raj", Dob = DateTime.Parse("11/11/2012"), Salary = 444445.2, Gender = "Male", Dept = "CS" });
            lst.Add(new Employee { Id = 102, Name = "kumar", Dob = DateTime.Parse("09/11/2012"), Salary = 444464.2, Gender = "Male", Dept = "CS" });
            lst.Add(new Employee { Id = 103, Name = "Abhay", Dob = DateTime.Parse("06/11/2012"), Salary = 444447.2, Gender = "Male", Dept = "CS" });
            foreach (Employee employee in lst)
            {
               // Console.WriteLine("Employee id={0} Name={1} Dob={2},Salary={3} Gender={4} Dept={5}", employee.Id, employee.Name, employee.Dob, employee.Salary, employee.Gender, employee.Dept);
                Console.WriteLine(employee);
            }

           
        }
    }
    class Employee
    {
        public int Id { get; set; }//default property
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public double Salary { get; set; }
        public string Gender { get; set; }
        public string Dept { get; set; }

        //public int CompareTo(object obj)
        //{
        //    throw new NotImplementedException();
        //}

        public override string ToString()
        {
            return string.Format("Employee id={0} Name={1} Dob={2},Salary={3} Gender={4} Dept={5}", Id, Name,Dob, Salary, Gender,Dept);
        }


    }
}



