using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    class Admin : Worker
    {
        public override void GetLogin()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--- Admin ---");
            base.GetLogin();
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Show information");
            Console.WriteLine("Some info...\n");
        }
        public override void ChangeInfo()
        {
            Console.WriteLine("Change information");
            Console.WriteLine("Change info...\n" +
                "--------------- ---------------\n");
        }
    }
}
