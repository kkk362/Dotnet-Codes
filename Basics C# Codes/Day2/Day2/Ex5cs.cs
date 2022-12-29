using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Ex5cs
    {
        static void Main(string[] args)
        {
            Login login = new Login("Raj", "ss");
            Registration registration = new Registration("raj", "ss", "raj@gmail.com","Fname", "ss", 234234234);
        }
    }
    class Login
    {   string Username;
        string Password;
        public Login() { }
        public Login(string username, string password)
        {  Username = username;
            Password = password;
        }
    }
    class Registration:Login
    {
     
        string EmailId;
        string SecuirtyQuestion;
        string Answer;
        long Phone;
        public Registration
            (string username,string password,string emailId, string secuirtyQuestion, string answer, long phone):base(username, password)
        {
            EmailId = emailId;
            SecuirtyQuestion = secuirtyQuestion;
            Answer = answer;
            Phone = phone;
        }
    }
}
