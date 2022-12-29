using System;

namespace Day3_2
{
    class Ex2
    {
        static void Main(string[] args)
        {
            Employee employee = new PermanentEmployee();
            employee.Display();
         double salary =  employee.EmpSalary(10000);
            Console.WriteLine("Salary="+salary);
            employee = new Monthly();
            salary = employee.EmpSalary(10000);
            Console.WriteLine("Salary=" + salary);
            employee = new ContractEmployee();
            salary = employee.EmpSalary(10000);
            Console.WriteLine("Salary=" + salary);

        }
    }
   abstract class Employee
    {   public abstract double EmpSalary(double salary);
        public void Display()
        {
            Console.WriteLine("hello");
        }

    }
    class PermanentEmployee : Employee
    {
        public override double EmpSalary(double salary)
        {
            return  salary + salary * 0.1;
        }
    }
    class ContractEmployee : Employee
    {
        public override double EmpSalary(double salary)
        {
            return salary + salary * 0.2;
        }
    }
    class Monthly : Employee
    {
        public override double EmpSalary(double salary)
        {
            return salary + salary * 0.3;
        }
    }








}
