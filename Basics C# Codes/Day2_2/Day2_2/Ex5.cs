using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_2
{
    class Ex5
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter the Emp Details");
            Console.WriteLine("Enter the Id");
            int id = int.Parse(Console.ReadLine());
            employee.Id = id;
            Console.WriteLine("Enter the Name");
            string name = Console.ReadLine();
            employee.Name = name;
            Console.WriteLine("Enter the Salary");
            double salary = double.Parse(Console.ReadLine());
            employee.Salary = salary;
            Console.WriteLine(employee);
            

        }
    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return string.Format("Id={0} Name={1} Salary={2}", Id, Name, Salary);
        }
    }
}
