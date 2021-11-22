using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class classOne = new ClassInt();
            classOne.SetValue(5, "Hello World", 5.06, 'c');
            if (classOne is ClassInt classInt)
            {
                classInt.SetValue(5, "Hello World", 5.06, 'c');
            }

            classOne = new ClassString();
            if (classOne is ClassString classString)
            {
                classString.SetValue(5, "Hello World", 5.06, 'c');
            }

            classOne = new ClassDouble();
            if (classOne is ClassDouble classDouble)
            {
                classDouble.SetValue(5, "Hello World", 5.06, 'c');
            }

            classOne = new ClassChar();
            if (classOne is ClassChar classChar)
            {
                classChar.SetValue(5, "Hello World", 5.06, 'c');
            }

            Console.ReadLine();
        }
    }
}
