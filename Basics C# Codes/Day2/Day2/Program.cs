using System;
namespace Day2
{
    //every class have a default constructor
    class Team
    {
        internal int TeamId = 101;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team();

            Team team1;//team1 is the object of class Team or team1 is the ref variable class Team
            team1 = new Team();//Team() default constructor  //new Team() instance create using new 
            Console.WriteLine(team1.TeamId);



            //default,parameter,non parameter,static ,private 
        }
    }
}
