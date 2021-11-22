using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class ClassInt : Class
    {
        public new void SetValue(int A, string B, double C, char D)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Class Int");
            Console.WriteLine($"A = {A}\n" +
                $"Type: Int\n" +
                $"---------- ----------\n");
        }
    }
}
