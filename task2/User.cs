using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    class User : Worker
    {
        public override void GetLogin()
        {
            TypeUser = "User";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--- User ---");
            base.GetLogin();
            PrintToDebug();
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You do not have the required permissions\n");
        }
        public override void ChangeInfo()
        {
            // Console.ForegroundColor = ConsoleColor.White;
            base.ChangeInfo();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You do not have the required permissions\n" +
                "--------------- ---------------\n");
        }
    }
}
