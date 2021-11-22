using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class ClassDouble : Class
    {
        public new void SetValue(int A, string B, double C, char D)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Class Double");
            Console.WriteLine($"C = {C}\n" +
                $"Type: Double\n" +
                $"---------- ----------\n");
        }
    }
}
