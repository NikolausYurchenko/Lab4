using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class ClassInt : Class
    {
        public new void SetValue(int A, string B, double C, char D)
        {
            base.A = A;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Class Int");
            Console.WriteLine($"A = {base.A}\n" +
                $"Type: Int\n" +
                $"---------- ----------\n");
        }
    }
}
