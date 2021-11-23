using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    class Worker
    {
        private string _typeUser;
        protected string _password;
        
        public string TypeUser
        {
            set
            {
                _typeUser = value;
            }
        }
        public string Password
        {
            set
            {
                _password = value;
            }
        }
        public virtual void GetLogin()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter password\n" +
                "Password: ");
            Password = Console.ReadLine();
            Console.WriteLine($"Your password: {_password}\n");
        }

        public virtual void ShowInfo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Show information");
            Console.WriteLine("Only Manager and Admin can look through information");
        }
        public virtual void ChangeInfo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Change information");
            Console.WriteLine("Only Admin can change information");
        }
    }
}
