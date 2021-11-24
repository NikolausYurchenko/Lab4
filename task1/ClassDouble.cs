using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class ClassDouble : Class
    {
        public new void SetValue(int A, string B, double C, char D)
        {
            base.C = C;
            Console.ForegroundColor = ConsoleColor.Cyan;
            base.PrintToDebug(base.C, "_c", "double");
            Console.WriteLine("Class Double");
            Console.WriteLine($"C = {base.C}\n" +
                $"Type: Double\n" +
                $"---------- ----------\n");
        }
    }
}
