using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class ClassString : Class
    {
        public new void SetValue(int A, string B, double C, char D)
        {
            base.B = B;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Class String");
            Console.WriteLine($"B = {base.B}\n" +
                $"Type: String\n" +
                $"---------- ----------\n");
        }
    }
}
