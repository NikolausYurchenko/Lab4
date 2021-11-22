using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class ClassChar : Class
    {
        public new void SetValue(int A, string B, double C, char D)
        {
            base.D = D;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Class Char");
            Console.WriteLine($"D = {base.D}\n" +
                $"Type: Char\n" +
                $"---------- ----------\n");
        }
    }
}
