using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    class Manager : Worker
    {
        public override void GetLogin()
        {
            TypeUser = "Manager";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--- Manager ---");
            base.GetLogin();
            PrintToDebug();
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Show information");
            Console.WriteLine("Some info...\n");
        }
        public override void ChangeInfo()
        {
            base.ChangeInfo();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You do not have the required permissions\n" +
                "--------------- ---------------\n");
        }
    }
}
